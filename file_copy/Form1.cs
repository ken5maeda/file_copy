using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_copy
{
    public partial class Form1 : Form
    {
        private String mFromDirectry;
        public Form1()
        {
            InitializeComponent();

            // ドライブ一覧を走査してツリーに追加
            foreach (String drive in Environment.GetLogicalDrives())
            {
                // 新規ノード作成
                // プラスボタンを表示するため空のノードを追加しておく
                TreeNode node = new TreeNode(drive);
                node.Nodes.Add(new TreeNode());
                trvDirectry.Nodes.Add(node);
            }
            // 初期選択ドライブの内容を表示
            setListItem(Environment.GetLogicalDrives().First());

            // リストビューのヘッダーを設定
            lvToFrom.View = View.Details;
            lvToFrom.Clear();
            lvToFrom.Columns.Add("To");
            lvToFrom.Columns.Add("From");
            lvToFrom.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        /// <summary>
        /// ツリービュー項目展開時（前）のイベントハンドラ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            String path = node.FullPath;
            node.Nodes.Clear();

            try
            {
                DirectoryInfo dirList = new DirectoryInfo(path);
                foreach (DirectoryInfo di in dirList.GetDirectories())
                {
                    TreeNode child = new TreeNode(di.Name);
                    child.Nodes.Add(new TreeNode());
                    node.Nodes.Add(child);
                }
            }
            catch (IOException ie)
            {
                MessageBox.Show(ie.Message, "選択エラー");
            }

        }

        /// <summary>
        /// ファイルサイズを単位付きに変換して返します.
        /// </summary>
        /// <param name="fileSize"></param>
        /// <returns></returns>
        private String getFileSize(long fileSize)
        {
            String ret = fileSize + " Byte";
            if (fileSize > (1024f * 1024f * 1024f))
            {
                ret = Math.Round((fileSize / 1024f / 1024f / 1024f), 2).ToString() + " GB";
            }
            else if(fileSize > (1024f * 1024f))
                {
                ret = Math.Round((fileSize / 1024f / 1024f), 2).ToString() + " MB";
            }
            else if(fileSize > 1024f)
                {
                ret = Math.Round((fileSize / 1024f)).ToString() + " KB";
            }

            return ret;
        }

        /// <summary>
        /// リストビューの項目を設定します.
        /// </summary>
        private void setListItem(String filePath)
        {
            // リストビューのヘッダーを設定
            lvFile.Clear();
            lvFile.Columns.Add("name");
            lvFile.Columns.Add("date");
            lvFile.Columns.Add("size");

            String match = tbxFilter.Text;
            if (match == "")
            {
                match = ".+";
            }
            else
            {
                match = "^" + match.Replace("*", ".+") + "$";
            }
            match = "^" + match.Replace("*", ".+") + "$";

            try
            {
                // ファイル一覧
                List<String> files = Directory.GetFiles(filePath).ToList<String>();
                foreach (String file in files)
                {
                    FileInfo info = new FileInfo(file);
                    String name = info.Name;
                    if (Regex.IsMatch(name, match))
                    {
                        ListViewItem item = new ListViewItem(name);
                        item.SubItems.Add(String.Format("{0:yyyy/MM/dd HH:mm:ss}", info.LastAccessTime));
                        item.SubItems.Add(getFileSize(info.Length));
                        lvFile.Items.Add(item);
                    }
                }
            }
            catch (IOException ie)
            {
                MessageBox.Show(ie.Message, "選択エラー");
            }

            // 列幅を自動調整
            lvFile.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// ツリービュー項目選択時（前）のイベントハンドラ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            mFromDirectry = e.Node.FullPath;
            setListItem(mFromDirectry);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxTo.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String ToDirectry = tbxTo.Text;
            foreach (ListViewItem item in lvFile.SelectedItems)
            {
                String fileName = item.Text;
                ListViewItem toFrom = new ListViewItem(ToDirectry);
                toFrom.SubItems.Add(Path.Combine(mFromDirectry, fileName));
                lvToFrom.Items.Add(toFrom);
            }
            lvToFrom.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvToFrom.SelectedItems)
            {
                lvToFrom.Items.Remove(item);
            }
        }

        private void btnCleare_Click(object sender, EventArgs e)
        {
            lvToFrom.Clear();
            lvToFrom.Columns.Add("To");
            lvToFrom.Columns.Add("From");
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            setListItem(mFromDirectry);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvToFrom.Items)
            {
                String FromDirectry = item.SubItems[1].Text;
                String FromFile = Path.GetFileName(FromDirectry);
                String toDirectry = Path.Combine(item.Text, FromFile);

                try
                {
                    if (cbOverwrite.Checked)
                    {
                        File.Copy(FromDirectry, toDirectry, true);
                    }
                    else
                    {
                        File.Copy(FromDirectry, toDirectry);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "File not found");
                }
                catch (DirectoryNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Directry not found");
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "File already exist");
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message, "Access error");
                }
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvToFrom.Items)
            {
                String FromDirectry = item.SubItems[1].Text;
                String FromFile = Path.GetFileName(FromDirectry);
                String toDirectry = Path.Combine(item.Text, FromFile);

                try
                {
                    if (cbOverwrite.Checked && File.Exists(toDirectry))
                    {
                        File.Delete(toDirectry);
                    }
                    File.Move(FromDirectry, toDirectry);
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "File not found");
                }
                catch (DirectoryNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Directry not found");
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "File already exist");
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message, "Access error");
                }
            }
        }
    }
}
