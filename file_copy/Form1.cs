using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_copy
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 最後に選択したコピー元ディレクトリパス
        /// </summary>
        private String mFromDirectry;
        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

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

            // リストビューの初期設定
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
                MessageBox.Show(ie.Message, "error");
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
            else if (fileSize > (1024f * 1024f))
            {
                ret = Math.Round((fileSize / 1024f / 1024f), 2).ToString() + " MB";
            }
            else if (fileSize > 1024f)
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

            // フィルター文字列を正規表現用文字列に変換
            String match = tbxFilter.Text;
            if (match == "")
            {
                match = ".+";
            }
            else
            {
                match = "^" + match.Replace("*", ".+") + "$";
            }

            try
            {
                // ファイル一覧
                List<String> files = Directory.GetFiles(filePath).ToList<String>();
                foreach (String file in files)
                {
                    FileInfo info = new FileInfo(file);
                    String name = info.Name;
                    // フィルター条件に合うファイルのみ表示
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
                MessageBox.Show(ie.Message, "error");
            }

            // 列幅を自動調整
            lvFile.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// ツリービュー項目選択時（前）のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trvDirectry_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            mFromDirectry = e.Node.FullPath;
            setListItem(mFromDirectry);
        }

        /// <summary>
        /// コピー先ディレクトリ選択ボタン押下時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectToDirectry_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbxToDirectry.Text = folderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// フィルター適応ボタン押下時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (mFromDirectry != null)
            {
                setListItem(mFromDirectry);
            }
        }


        /// <summary>
        /// 一括更新リストに追加するボタン押下時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String toDirectry = tbxToDirectry.Text;
            if (toDirectry == "")
            {
                MessageBox.Show("Select a destination directory", "error");
            }
            else
            {
                foreach (ListViewItem item in lvFile.SelectedItems)
                {
                    String fileName = item.Text;
                    ListViewItem toFrom = new ListViewItem(toDirectry);
                    toFrom.SubItems.Add(Path.Combine(mFromDirectry, fileName));
                    lvToFrom.Items.Add(toFrom);
                }
                lvToFrom.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }


        /// <summary>
        /// 削除ボタン押下時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvToFrom.SelectedItems)
            {
                lvToFrom.Items.Remove(item);
            }
        }

        /// <summary>
        /// クリアボタン押下時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCleare_Click(object sender, EventArgs e)
        {
            lvToFrom.Clear();
            lvToFrom.Columns.Add("To");
            lvToFrom.Columns.Add("From");
        }

        /// <summary>
        /// コピーボタン押下時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    MessageBox.Show(ex.Message, "File already exists");
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message, "Access error");
                }
            }
        }

        /// <summary>
        /// 移動ボタン押下時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tbxToDirectry_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (File.Exists(files[0]))
            {
                tbxToDirectry.Text += Path.GetDirectoryName(files[0]);
            }
            else
            {
                tbxToDirectry.Text += files[0];
            }
        }

        private void lvToFrom_DragDrop(object sender, DragEventArgs e)
        {
            String toDirectry = tbxToDirectry.Text;
            if (toDirectry == "")
            {
                MessageBox.Show("Select a destination directory", "error");
            }
            else
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                foreach (string file in files)
                {
                    if (File.Exists(file))
                    {
                        ListViewItem toFrom = new ListViewItem(toDirectry);
                        toFrom.SubItems.Add(file);
                        lvToFrom.Items.Add(toFrom);
                    }
                }
                lvToFrom.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
    }
}
