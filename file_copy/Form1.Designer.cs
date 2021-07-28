
namespace file_copy
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.trvDirectry = new System.Windows.Forms.TreeView();
            this.lvFile = new System.Windows.Forms.ListView();
            this.lvToFrom = new System.Windows.Forms.ListView();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlp3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectToDirectry = new System.Windows.Forms.Button();
            this.tbxToDirectry = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.tlp4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblList = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tlp6 = new System.Windows.Forms.TableLayoutPanel();
            this.cbOverwrite = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCleare = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.tlp2_1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.tlpBase.SuspendLayout();
            this.tlp3.SuspendLayout();
            this.tlp1.SuspendLayout();
            this.tlp4.SuspendLayout();
            this.tlp6.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.tlp2_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvDirectry
            // 
            this.trvDirectry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvDirectry.Location = new System.Drawing.Point(3, 2);
            this.trvDirectry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trvDirectry.Name = "trvDirectry";
            this.trvDirectry.Size = new System.Drawing.Size(223, 332);
            this.trvDirectry.TabIndex = 0;
            this.trvDirectry.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.trvDirectry.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvDirectry_NodeMouseClick);
            // 
            // lvFile
            // 
            this.lvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFile.FullRowSelect = true;
            this.lvFile.HideSelection = false;
            this.lvFile.Location = new System.Drawing.Point(232, 2);
            this.lvFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(339, 332);
            this.lvFile.TabIndex = 1;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            // 
            // lvToFrom
            // 
            this.lvToFrom.AllowDrop = true;
            this.lvToFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvToFrom.FullRowSelect = true;
            this.lvToFrom.HideSelection = false;
            this.lvToFrom.Location = new System.Drawing.Point(3, 463);
            this.lvToFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvToFrom.Name = "lvToFrom";
            this.lvToFrom.Size = new System.Drawing.Size(574, 336);
            this.lvToFrom.TabIndex = 2;
            this.lvToFrom.UseCompatibleStateImageBehavior = false;
            this.lvToFrom.View = System.Windows.Forms.View.Details;
            this.lvToFrom.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvToFrom_DragDrop);
            this.lvToFrom.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            // 
            // tlpBase
            // 
            this.tlpBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.tlp3, 0, 2);
            this.tlpBase.Controls.Add(this.lvToFrom, 0, 4);
            this.tlpBase.Controls.Add(this.tlp1, 0, 0);
            this.tlpBase.Controls.Add(this.tlp4, 0, 3);
            this.tlpBase.Controls.Add(this.tlp6, 0, 5);
            this.tlpBase.Controls.Add(this.tlp2, 0, 1);
            this.tlpBase.Location = new System.Drawing.Point(1, 2);
            this.tlpBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 6;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.Size = new System.Drawing.Size(580, 850);
            this.tlpBase.TabIndex = 3;
            // 
            // tlp3
            // 
            this.tlp3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp3.ColumnCount = 2;
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp3.Controls.Add(this.trvDirectry, 0, 0);
            this.tlp3.Controls.Add(this.lvFile, 1, 0);
            this.tlp3.Location = new System.Drawing.Point(3, 82);
            this.tlp3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp3.Name = "tlp3";
            this.tlp3.RowCount = 1;
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp3.Size = new System.Drawing.Size(574, 336);
            this.tlp3.TabIndex = 0;
            // 
            // tlp1
            // 
            this.tlp1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp1.ColumnCount = 3;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp1.Controls.Add(this.btnSelectToDirectry, 2, 0);
            this.tlp1.Controls.Add(this.tbxToDirectry, 1, 0);
            this.tlp1.Controls.Add(this.lblTo, 0, 0);
            this.tlp1.Location = new System.Drawing.Point(3, 2);
            this.tlp1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 1;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Size = new System.Drawing.Size(574, 31);
            this.tlp1.TabIndex = 3;
            // 
            // btnSelectToDirectry
            // 
            this.btnSelectToDirectry.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectToDirectry.Location = new System.Drawing.Point(520, 2);
            this.btnSelectToDirectry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectToDirectry.Name = "btnSelectToDirectry";
            this.btnSelectToDirectry.Size = new System.Drawing.Size(51, 25);
            this.btnSelectToDirectry.TabIndex = 2;
            this.btnSelectToDirectry.Text = "...";
            this.btnSelectToDirectry.UseVisualStyleBackColor = true;
            this.btnSelectToDirectry.Click += new System.EventHandler(this.btnSelectToDirectry_Click);
            // 
            // tbxToDirectry
            // 
            this.tbxToDirectry.AllowDrop = true;
            this.tbxToDirectry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxToDirectry.Location = new System.Drawing.Point(38, 5);
            this.tbxToDirectry.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.tbxToDirectry.Name = "tbxToDirectry";
            this.tbxToDirectry.Size = new System.Drawing.Size(476, 22);
            this.tbxToDirectry.TabIndex = 1;
            this.tbxToDirectry.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbxToDirectry_DragDrop);
            this.tbxToDirectry.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.Location = new System.Drawing.Point(3, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 31);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "To";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlp4
            // 
            this.tlp4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp4.AutoSize = true;
            this.tlp4.ColumnCount = 2;
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp4.Controls.Add(this.lblList, 0, 0);
            this.tlp4.Controls.Add(this.btnAdd, 1, 0);
            this.tlp4.Location = new System.Drawing.Point(3, 422);
            this.tlp4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp4.Name = "tlp4";
            this.tlp4.RowCount = 1;
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp4.Size = new System.Drawing.Size(574, 37);
            this.tlp4.TabIndex = 8;
            // 
            // lblList
            // 
            this.lblList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblList.AutoSize = true;
            this.lblList.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblList.Location = new System.Drawing.Point(3, 22);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(30, 15);
            this.lblList.TabIndex = 5;
            this.lblList.Text = "List";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(496, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tlp6
            // 
            this.tlp6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp6.AutoSize = true;
            this.tlp6.ColumnCount = 5;
            this.tlp6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp6.Controls.Add(this.cbOverwrite, 0, 0);
            this.tlp6.Controls.Add(this.btnDelete, 1, 0);
            this.tlp6.Controls.Add(this.btnCleare, 2, 0);
            this.tlp6.Controls.Add(this.btnCopy, 3, 0);
            this.tlp6.Controls.Add(this.btnMove, 4, 0);
            this.tlp6.Location = new System.Drawing.Point(3, 811);
            this.tlp6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.tlp6.Name = "tlp6";
            this.tlp6.RowCount = 1;
            this.tlp6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp6.Size = new System.Drawing.Size(574, 29);
            this.tlp6.TabIndex = 6;
            // 
            // cbOverwrite
            // 
            this.cbOverwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOverwrite.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cbOverwrite.Location = new System.Drawing.Point(79, 2);
            this.cbOverwrite.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.cbOverwrite.Name = "cbOverwrite";
            this.cbOverwrite.Size = new System.Drawing.Size(100, 25);
            this.cbOverwrite.TabIndex = 0;
            this.cbOverwrite.Text = "Overwrite";
            this.cbOverwrite.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(202, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCleare
            // 
            this.btnCleare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCleare.Location = new System.Drawing.Point(300, 2);
            this.btnCleare.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.btnCleare.Name = "btnCleare";
            this.btnCleare.Size = new System.Drawing.Size(75, 25);
            this.btnCleare.TabIndex = 2;
            this.btnCleare.Text = "Cleare";
            this.btnCleare.UseVisualStyleBackColor = true;
            this.btnCleare.Click += new System.EventHandler(this.btnCleare_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCopy.Location = new System.Drawing.Point(398, 2);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 25);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMove.Location = new System.Drawing.Point(496, 2);
            this.btnMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 25);
            this.btnMove.TabIndex = 4;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // tlp2
            // 
            this.tlp2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp2.AutoSize = true;
            this.tlp2.ColumnCount = 2;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp2.Controls.Add(this.lblFrom, 0, 0);
            this.tlp2.Controls.Add(this.tlp2_1, 1, 0);
            this.tlp2.Location = new System.Drawing.Point(3, 37);
            this.tlp2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 1;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Size = new System.Drawing.Size(574, 41);
            this.tlp2.TabIndex = 9;
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFrom.Location = new System.Drawing.Point(3, 16);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(88, 25);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tlp2_1
            // 
            this.tlp2_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp2_1.AutoSize = true;
            this.tlp2_1.ColumnCount = 3;
            this.tlp2_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp2_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp2_1.Controls.Add(this.tbxFilter, 1, 0);
            this.tlp2_1.Controls.Add(this.lblFilter, 0, 0);
            this.tlp2_1.Controls.Add(this.btnApply, 2, 0);
            this.tlp2_1.Location = new System.Drawing.Point(232, 2);
            this.tlp2_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp2_1.Name = "tlp2_1";
            this.tlp2_1.RowCount = 1;
            this.tlp2_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2_1.Size = new System.Drawing.Size(339, 37);
            this.tlp2_1.TabIndex = 1;
            // 
            // tbxFilter
            // 
            this.tbxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFilter.Location = new System.Drawing.Point(48, 10);
            this.tbxFilter.Margin = new System.Windows.Forms.Padding(3, 10, 3, 2);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(207, 22);
            this.tbxFilter.TabIndex = 2;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(3, 12);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(39, 15);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filter";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(261, 10);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 10, 3, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 25);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 852);
            this.Controls.Add(this.tlpBase);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(599, 598);
            this.Name = "Form1";
            this.Text = "FileCopy";
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.tlp3.ResumeLayout(false);
            this.tlp1.ResumeLayout(false);
            this.tlp1.PerformLayout();
            this.tlp4.ResumeLayout(false);
            this.tlp4.PerformLayout();
            this.tlp6.ResumeLayout(false);
            this.tlp2.ResumeLayout(false);
            this.tlp2.PerformLayout();
            this.tlp2_1.ResumeLayout(false);
            this.tlp2_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TreeView trvDirectry;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ListView lvToFrom;
        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlp3;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox tbxToDirectry;
        private System.Windows.Forms.Button btnSelectToDirectry;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox tbxFilter;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.TableLayoutPanel tlp6;
        private System.Windows.Forms.CheckBox cbOverwrite;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCleare;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TableLayoutPanel tlp2_1;
        private System.Windows.Forms.TableLayoutPanel tlp4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tlp2;
    }
}

