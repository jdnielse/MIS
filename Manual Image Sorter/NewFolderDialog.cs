using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manual_Image_Sorter
{
    public partial class NewFolderDialog : Form
    {
        public NewFolderDialog()
        {
            InitializeComponent();
        }

        public string Folder
        {
            get { return folderText.Text; }
            set { folderText.Text = value; }
        }
    }
}
