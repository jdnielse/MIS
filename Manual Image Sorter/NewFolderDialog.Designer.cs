namespace Manual_Image_Sorter
{
    partial class NewFolderDialog
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
            this.folderText = new System.Windows.Forms.TextBox();
            this.folderOK = new System.Windows.Forms.Button();
            this.folderCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderText
            // 
            this.folderText.Location = new System.Drawing.Point(12, 12);
            this.folderText.Name = "folderText";
            this.folderText.Size = new System.Drawing.Size(167, 20);
            this.folderText.TabIndex = 0;
            // 
            // folderOK
            // 
            this.folderOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.folderOK.Location = new System.Drawing.Point(12, 38);
            this.folderOK.Name = "folderOK";
            this.folderOK.Size = new System.Drawing.Size(86, 23);
            this.folderOK.TabIndex = 1;
            this.folderOK.Text = "Create Folder";
            this.folderOK.UseVisualStyleBackColor = true;
            // 
            // folderCancel
            // 
            this.folderCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.folderCancel.Location = new System.Drawing.Point(104, 38);
            this.folderCancel.Name = "folderCancel";
            this.folderCancel.Size = new System.Drawing.Size(75, 23);
            this.folderCancel.TabIndex = 2;
            this.folderCancel.Text = "Cancel";
            this.folderCancel.UseVisualStyleBackColor = true;
            // 
            // NewFolderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 70);
            this.Controls.Add(this.folderCancel);
            this.Controls.Add(this.folderOK);
            this.Controls.Add(this.folderText);
            this.Name = "NewFolderDialog";
            this.Text = "New Folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderText;
        private System.Windows.Forms.Button folderOK;
        private System.Windows.Forms.Button folderCancel;
    }
}