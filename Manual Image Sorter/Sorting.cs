/**
 * A program that allows users to sort through images quickly
 * By Jon Nielsen and James Dwyer
 * 
 * 
 * TODO:
 *      
 *  SMALL:
 *      different sort orders
 *      undo button - for delete and folder move
 *      key bindings:
 *          space - skip
 *          assignable buttons for each folder or just label each folder as a key?
 *          left alt - delete
 *      
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Microsoft.VisualBasic;


namespace Manual_Image_Sorter
{
    public partial class Sorting : Form
    {
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPEG", ".JPE", ".BMP", ".GIF", ".PNG", ".SWF" };
        ArrayList files = new ArrayList();
        ArrayList skipped = new ArrayList();
        ArrayList folders = new ArrayList(); //stores the folders at the current folder
        string currPath = ""; //stores the path to the currently displayed file
        System.Drawing.Image currImage; //the image object of the currently displayed image
        string basePath; //the folder being viewed
        StreamWriter sw; 
        string currExtension; //the extension of the current file
        ArrayList custFolders = new ArrayList(); //stores the user custom folders
        bool singleClick = false;
        int currIndex = -1;
        

        public Sorting()
        {
            InitializeComponent();
            imageDisplay.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (basePath != null) fbd.SelectedPath = basePath;
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.Cancel) return;

            string[] f = Directory.GetFiles(fbd.SelectedPath);
            string[] fold = Directory.GetDirectories(fbd.SelectedPath);
            
            if (fold.Length <= 0)
            {
                MessageBox.Show(this, "The selected folder has no subfolders in it");
            }

            folders.Clear();
            foreach (string s in fold)
            {
                folders.Add(s);
            }

            files.Clear();
            foreach (string s in f)
            {
                //determine if file is an image
                if (ImageExtensions.Contains(Path.GetExtension(s).ToUpperInvariant()))
                {
                    files.Add(s);
                    basePath = getHead(s);
                }
            }
            if (files.Count <= 0)
            {
                MessageBox.Show(this, "The selected folder has no images in it");
                return;
            }
            //display the first image
            nextImage();

            //setup the folder list
            refreshFolderList();

            //enable create folder
            enableButts();

            //reset custFolders
            custFolders.Clear();
            

        }

        //helper method that reads all current folders
        private void refreshFolderList()
        {
            folderList.Items.Clear();
            folderList.Clear();
            
            folderList.View = View.Details;
            folderList.Columns.Add("Folder");
            folderList.Columns[0].Width = this.folderList.Width - 4;
            folderList.HeaderStyle = ColumnHeaderStyle.None;
            folderList.Items.Add(".."); //add the parent folder
            foreach (string s in folders)
            {
                folderList.Items.Add(getFileName(s));
                basePath = getHead(s);

            }
        }

        public void enableButts()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            deleteButton.Enabled = true;
            button5.Enabled = true;
            hideButt.Enabled = true;
            butBack.Enabled = true;
        }

        public void disableButts()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            deleteButton.Enabled = false;
            button5.Enabled = false;
            hideButt.Enabled = false;
            butBack.Enabled = false;
            
        }

        public void EquivalentSplit(string path, out string head, out string tail)
        {

            // Get the directory separation character (i.e. '\').
            string separator = System.IO.Path.DirectorySeparatorChar.ToString();

            // Trim any separators at the end of the path
            string lastCharacter = path.Substring(path.Length - 1);
            if (separator == lastCharacter)
            {
                path = path.Substring(0, path.Length - 1);
            }

            int lastSeparatorIndex = path.LastIndexOf(separator);

            head = path.Substring(0, lastSeparatorIndex);
            tail = path.Substring(lastSeparatorIndex + separator.Length,
                path.Length - lastSeparatorIndex - separator.Length);

        }

        public string getFileName(string path)
        {
            string h, t;
            EquivalentSplit(path, out h,out t);
            return t;
        }

        public string getHead(string path)
        {
            string h, t;
            EquivalentSplit(path, out h, out t);
            return h;
        }

        public string getFileType(string path)
        {

            // Get the directory separation character (i.e. '\').
            string separator = ".";

            // Trim any separators at the end of the path
            string lastCharacter = path.Substring(path.Length - 1);
            if (separator == lastCharacter)
            {
                path = path.Substring(0, path.Length - 1);
            }

            int lastSeparatorIndex = path.LastIndexOf(separator);

            return "."+path.Substring(lastSeparatorIndex + separator.Length,
                path.Length - lastSeparatorIndex - separator.Length);

        }


        // Move button
        private void button1_Click(object sender, EventArgs e)
        {
            folderList_DoubleClick(sender, e);
        }

        // Exit button
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Delete button
        private void button4_Click(object sender, EventArgs e)
        {
            if (!singleClickDeleteToolStripMenuItem.Checked)
            {
                DialogResult deleteThis = MessageBox.Show("This file will be permanently deleted. Are you sure you want to delete this file?", "Delete image", MessageBoxButtons.YesNo);
                if (deleteThis == DialogResult.Yes)
                {
                    imageDisplay.Image = null;
                    currImage.Dispose();

                    File.Delete(currPath);
                    nextImage();
                }
            }
            else
            {
                imageDisplay.Image = null;
                currImage.Dispose();

                File.Delete(currPath);
                nextImage();
            }
        }

        // Skip button
        private void button5_Click(object sender, EventArgs e)
        {
            skipped.Add(currPath);
            nextImage();
        }

        // Enter folder button
        private void button3_Click(object sender, EventArgs e)
        {
            openFolderToolStripMenuItem_Click(sender, e);
        }

        // New folder
        private void button2_Click(object sender, EventArgs e)
        {
            NewFolderDialog _folderDialog = new NewFolderDialog();
            DialogResult dialogResult = _folderDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                Directory.CreateDirectory(basePath + "\\" + _folderDialog.Folder);
                folders.Clear();

                string[] fold = Directory.GetDirectories(basePath);
                foreach (string s in fold)
                {
                    folders.Add(s);
                }
                refreshFolderList();
            }

        }

        private void folderList_DoubleClick(object sender, EventArgs e)
        {
            if (folderList.SelectedItems.Count <= 0)
            {
                //message box 
                MessageBox.Show(this, "Select a folder");
                return;
            }
            string newPath = (basePath.ToString() + "\\" + folderList.SelectedItems[0].Text + "\\" + getFileName(currPath)); //this works for .. too

            // Ensure that the target does not exist. 
            if (File.Exists(newPath))
            {
                MessageBox.Show(this, "File already exists, please rename the current image");
                return;
            }

            //move the file
            imageDisplay.Image = null;
            currImage.Dispose();
            File.Move(currPath, newPath);
            files[currIndex] = null; //set the current index to null so we know the image does't exist
            nextImage();
            
        }

        private void folderList_Click(object sender, EventArgs e)
        {
            if (singleClick)
            {
                folderList_DoubleClick(sender, e);
            }
        }

        public void nextImage()
        {
            try
            {
                while (files[++currIndex] == null) ; //go back past nonexistant ones
            }
            catch (ArgumentOutOfRangeException e)
            {
                //there are no images before the current one - try from the end
                currIndex = 0;
                try
                {
                    while (files[++currIndex] == null) ; //this will always work since we will eventually get back to the only image remaining
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    //say end of images
                    folderList.Items.Clear();
                    folderList.Clear();
                    imageDisplay.Image = null;
                    disableButts();
                    imageName.Text = "";
                    currPath = "";
                    currIndex = 0;
                    this.Text = "Manual Image Sorter";
                    MessageBox.Show("No images left in folder");
                    return;
                }
            }

            currPath = files[currIndex] as string;
            if (getFileType(currPath) != ".swf")
            {
                flashView.Movie = "empty.swf"; //easiest way to stop the last flash from playing
                flashView.Visible = false;
                imageDisplay.Visible = true;
                if(currImage != null) currImage.Dispose();
                currImage = System.Drawing.Image.FromFile(currPath);
                imageDisplay.Image = currImage;
            }
            else
            {
                flashView.Visible = true;
                imageDisplay.Visible = false;
                flashView.Movie = currPath;
            }

            imageName.Text = getFileName(currPath);
            this.Text = imageName.Text;
            currExtension = getFileType(currPath);

        }

        public void lastImage()
        {
            try
            {
                while (files[--currIndex] == null) ; //go back past nonexistant ones
            } 
            catch(ArgumentOutOfRangeException e)
            {
                //there are no images before the current one - try from the end
                currIndex = files.Count;
                while (files[--currIndex] == null) ; //this will always work since we will eventually get back to the only image remaining
            }

            currPath = files[currIndex] as string;
            if (getFileType(currPath) != ".swf")
            {
                flashView.Movie = "empty.swf"; //easiest way to stop the last flash from playing
                flashView.Visible = false;
                imageDisplay.Visible = true;
                if (currImage != null) currImage.Dispose();
                currImage = System.Drawing.Image.FromFile(currPath);
                imageDisplay.Image = currImage;
            }
            else
            {
                flashView.Visible = true;
                imageDisplay.Visible = false;
                flashView.Movie = currPath;
            }
            imageName.Text = getFileName(currPath);
            this.Text = imageName.Text;
            currExtension = getFileType(currPath);

        }

        //public void nextImage()
        //{
        //    files.RemoveAt(0);
        //    if (files.Count <= 0)
        //    {
        //        if (skipped.Count <= 0)
        //        {

        //            //say end of images
        //            folderList.Items.Clear();
        //            folderList.Clear();
        //            imageDisplay.Image = null;
        //            disableButts();
        //            // sw.Close();
        //            imageName.Text = "";
        //            currPath = "";
        //            this.Text = "Manual Image Sorter";
        //            MessageBox.Show("No images left in folder");
        //            return;
        //        }
        //        else
        //        {

        //            MessageBox.Show("Ran through all images in folder, displaying remaining images");
        //            foreach (string s in skipped)
        //            {
        //                files.Add(s);
        //            }
        //            skipped.Clear();
        //        }
        //    }
                
        //        currPath = files[0] as string;
        //        currImage.Dispose();
        //        currImage = System.Drawing.Image.FromFile(currPath);
        //        imageDisplay.Image = currImage;
        //        imageName.Text = getFileName(currPath);
        //        this.Text = imageName.Text;
        //        currExtension = getFileType(currPath);
            
        //}

        private void butBack_Click(object sender, EventArgs e)
        {
            lastImage();
        }


        private void imageName_Leave(object sender, EventArgs e)
        {
            if (currPath == "")
            {
                imageName.Text = "";
                return; //there is no image loaded
            }
            if (imageName.Text == "") return;
            if (imageName.Text.Length < 6)
            {
                MessageBox.Show("File name must be 6 or more characters long");
                return;
            }
            //should get a better way of seeing if the extension was deleted....
            if (!imageName.Text.Substring(imageName.Text.Length - 6).Contains("."))
            {
                imageName.Text = imageName.Text + currExtension;
            }
            string newPath = getHead(currPath) + "\\" + imageName.Text;
            string oldPath = currPath;
            currPath = newPath;

            imageDisplay.Image = null;
            currImage.Dispose();
            File.Move(oldPath, currPath);


            currImage = System.Drawing.Image.FromFile(currPath);
            imageDisplay.Image = currImage;
            this.Text = imageName.Text;         
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //hides the currently selected folder
        private void hideButt_Click(object sender, EventArgs e)
        {
            if (folderList.SelectedItems.Count <= 0)
            {
                MessageBox.Show(this, "Select a folder to hide");
                return;
            }
            folderList.Items.Remove(folderList.SelectedItems[0]);
        }

        private void hideFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideButt_Click(sender, e);
        }

        private void newFolderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void deleteImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            folderList.Font = new Font( "Microsoft Sans Serif", 8);
        }

        private void toolStripFont10_Click(object sender, EventArgs e)
        {
            folderList.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void toolStripFont12_Click(object sender, EventArgs e)
        {
            folderList.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void toolStripFont14_Click(object sender, EventArgs e)
        {
            folderList.Font = new Font("Microsoft Sans Serif", 14);
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is meant to make sorting through large numbers of images faster than faster than doing the same task in Windows Explorer.\nFirst, you need a folder full of images. Then use the \"Open Folder\" menu to select that folder.\nThe first image in that folder will then be displayed. Simply double click any subfolder in the list to the right to move that image to that folder and move onto the next image.\nYou can create new subfolders from within the program with the \"Create Folder\" button.\nYou can hide folders that you do not want to sort into by selecting a folder then right clicking and selecting \"Hide folder\" or by clicking the hide folder button.");
        }

        //turn on single click move mode
        private void singleClickMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            singleClick = !singleClick;
            singleClickMoveToolStripMenuItem.Checked = singleClick;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Q:
                    lastImage();
                    return true;
                case Keys.Space:
                    nextImage();
                    return true;
                case Keys.E:
                    nextImage();
                    return true;
                case Keys.NumPad0:
                    lastImage();
                    return true;
                case Keys.Add:
                    nextImage();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }





    }
}
