namespace Manual_Image_Sorter
{
    partial class Sorting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageDisplay = new System.Windows.Forms.PictureBox();
            this.folderList = new System.Windows.Forms.ListView();
            this.folderListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hideFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleClickMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleClickDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderFontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFont8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFont10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFont12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFont14 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butBack = new System.Windows.Forms.Button();
            this.hideButt = new System.Windows.Forms.Button();
            this.imageName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
            this.folderListMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageDisplay
            // 
            this.imageDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imageDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imageDisplay.Location = new System.Drawing.Point(0, 27);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(609, 378);
            this.imageDisplay.TabIndex = 0;
            this.imageDisplay.TabStop = false;
            // 
            // folderList
            // 
            this.folderList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.folderList.ContextMenuStrip = this.folderListMenu;
            this.folderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderList.FullRowSelect = true;
            this.folderList.HideSelection = false;
            this.folderList.Location = new System.Drawing.Point(608, 27);
            this.folderList.MultiSelect = false;
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(197, 378);
            this.folderList.TabIndex = 7;
            this.folderList.TabStop = false;
            this.folderList.UseCompatibleStateImageBehavior = false;
            this.folderList.View = System.Windows.Forms.View.Details;
            this.folderList.Click += new System.EventHandler(this.folderList_Click);
            this.folderList.DoubleClick += new System.EventHandler(this.folderList_DoubleClick);
            // 
            // folderListMenu
            // 
            this.folderListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideFolderToolStripMenuItem,
            this.newFolderToolStripMenuItem1,
            this.deleteImageToolStripMenuItem});
            this.folderListMenu.Name = "folderListMenu";
            this.folderListMenu.Size = new System.Drawing.Size(150, 70);
            // 
            // hideFolderToolStripMenuItem
            // 
            this.hideFolderToolStripMenuItem.Name = "hideFolderToolStripMenuItem";
            this.hideFolderToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.hideFolderToolStripMenuItem.Text = "Hide Folder";
            this.hideFolderToolStripMenuItem.Click += new System.EventHandler(this.hideFolderToolStripMenuItem_Click);
            // 
            // newFolderToolStripMenuItem1
            // 
            this.newFolderToolStripMenuItem1.Name = "newFolderToolStripMenuItem1";
            this.newFolderToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.newFolderToolStripMenuItem1.Text = "New Folder";
            this.newFolderToolStripMenuItem1.Click += new System.EventHandler(this.newFolderToolStripMenuItem1_Click);
            // 
            // deleteImageToolStripMenuItem
            // 
            this.deleteImageToolStripMenuItem.Name = "deleteImageToolStripMenuItem";
            this.deleteImageToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.deleteImageToolStripMenuItem.Text = "Delete Image";
            this.deleteImageToolStripMenuItem.Click += new System.EventHandler(this.deleteImageToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(487, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "M&ove...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(325, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&New folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(579, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "En&ter folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(568, 11);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "D&elete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(730, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Next ->";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fToolStripMenuItem.Text = "File";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder...";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleClickMoveToolStripMenuItem,
            this.singleClickDeleteToolStripMenuItem,
            this.folderFontSizeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // singleClickMoveToolStripMenuItem
            // 
            this.singleClickMoveToolStripMenuItem.Name = "singleClickMoveToolStripMenuItem";
            this.singleClickMoveToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.singleClickMoveToolStripMenuItem.Text = "Single Click Move";
            this.singleClickMoveToolStripMenuItem.Click += new System.EventHandler(this.singleClickMoveToolStripMenuItem_Click);
            // 
            // singleClickDeleteToolStripMenuItem
            // 
            this.singleClickDeleteToolStripMenuItem.CheckOnClick = true;
            this.singleClickDeleteToolStripMenuItem.Name = "singleClickDeleteToolStripMenuItem";
            this.singleClickDeleteToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.singleClickDeleteToolStripMenuItem.Text = "Single Click Delete";
            // 
            // folderFontSizeToolStripMenuItem
            // 
            this.folderFontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFont8,
            this.toolStripFont10,
            this.toolStripFont12,
            this.toolStripFont14});
            this.folderFontSizeToolStripMenuItem.Name = "folderFontSizeToolStripMenuItem";
            this.folderFontSizeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.folderFontSizeToolStripMenuItem.Text = "Folder Font Size";
            // 
            // toolStripFont8
            // 
            this.toolStripFont8.Name = "toolStripFont8";
            this.toolStripFont8.Size = new System.Drawing.Size(86, 22);
            this.toolStripFont8.Text = "8";
            this.toolStripFont8.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripFont10
            // 
            this.toolStripFont10.Name = "toolStripFont10";
            this.toolStripFont10.Size = new System.Drawing.Size(86, 22);
            this.toolStripFont10.Text = "10";
            this.toolStripFont10.Click += new System.EventHandler(this.toolStripFont10_Click);
            // 
            // toolStripFont12
            // 
            this.toolStripFont12.Name = "toolStripFont12";
            this.toolStripFont12.Size = new System.Drawing.Size(86, 22);
            this.toolStripFont12.Text = "12";
            this.toolStripFont12.Click += new System.EventHandler(this.toolStripFont12_Click);
            // 
            // toolStripFont14
            // 
            this.toolStripFont14.Name = "toolStripFont14";
            this.toolStripFont14.Size = new System.Drawing.Size(86, 22);
            this.toolStripFont14.Text = "14";
            this.toolStripFont14.Click += new System.EventHandler(this.toolStripFont14_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.helpToolStripMenuItem1.Text = "Help...";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.butBack);
            this.panel1.Controls.Add(this.hideButt);
            this.panel1.Controls.Add(this.imageName);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 46);
            this.panel1.TabIndex = 9;
            // 
            // butBack
            // 
            this.butBack.AllowDrop = true;
            this.butBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butBack.Enabled = false;
            this.butBack.Location = new System.Drawing.Point(649, 11);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 5;
            this.butBack.Text = "<- Back";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // hideButt
            // 
            this.hideButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hideButt.Enabled = false;
            this.hideButt.Location = new System.Drawing.Point(406, 11);
            this.hideButt.Name = "hideButt";
            this.hideButt.Size = new System.Drawing.Size(75, 23);
            this.hideButt.TabIndex = 2;
            this.hideButt.Text = "Hide Folder";
            this.hideButt.UseVisualStyleBackColor = true;
            this.hideButt.Click += new System.EventHandler(this.hideButt_Click);
            // 
            // imageName
            // 
            this.imageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imageName.Location = new System.Drawing.Point(12, 14);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(307, 20);
            this.imageName.TabIndex = 0;
            this.imageName.Leave += new System.EventHandler(this.imageName_Leave);
            // 
            // Sorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(817, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.folderList);
            this.Controls.Add(this.imageDisplay);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sorting";
            this.Text = "Manual Image Sorter";
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
            this.folderListMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageDisplay;
        private System.Windows.Forms.ListView folderList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox imageName;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleClickDeleteToolStripMenuItem;
        private System.Windows.Forms.Button hideButt;
        private System.Windows.Forms.ContextMenuStrip folderListMenu;
        private System.Windows.Forms.ToolStripMenuItem hideFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderFontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripFont8;
        private System.Windows.Forms.ToolStripMenuItem toolStripFont10;
        private System.Windows.Forms.ToolStripMenuItem toolStripFont12;
        private System.Windows.Forms.ToolStripMenuItem toolStripFont14;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.ToolStripMenuItem singleClickMoveToolStripMenuItem;
    }
}

