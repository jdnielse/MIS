/**
 * A program that allows users to sort through images quickly
 * By Jon Nielsen and James Dwyer
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
    public partial class Form1 : Form
    {
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPEG", ".JPE", ".BMP", ".GIF", ".PNG" };
        ArrayList files = new ArrayList();
        ArrayList skipped = new ArrayList();
        ArrayList folders = new ArrayList(); //stores the folders at the current folder
        string currPath = ""; //stores the path to the currently displayed file
        Image currImage; //the image object of the currently displayed image
        string basePath; //the folder being viewed
        StreamWriter sw; 
        string currExtension; //the extension of the current file

        public Form1()
        {
            InitializeComponent();
            imageDisplay.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.Cancel) return;

            string[] f = Directory.GetFiles(fbd.SelectedPath);
            //Console.WriteLine("Files found: " + f.Length.ToString());
            string[] fold = Directory.GetDirectories(fbd.SelectedPath);
            
            if (fold.Length <= 0)
            {
                MessageBox.Show(this, "The selected folder has no subfolders in it");
                //Console.WriteLine("Found no folders");
            }

            folders.Clear();
            foreach (string s in fold)
            {
                //Console.WriteLine(s);
                folders.Add(s);
            }

            files.Clear();
            foreach (string s in f)
            {
                //Console.WriteLine(s);
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
                //Console.WriteLine("found no files");
                return;
                //die
            }
            //display the first image
            currPath = files[0] as string;
            if(currImage!=null) currImage.Dispose();
            currImage = Image.FromFile(currPath);
            imageDisplay.Image = currImage;
            imageName.Text = getFileName(currPath);
            this.Text = imageName.Text;
            currExtension = getFileType(currPath);

            //setup the folder list
            refreshFolderList();

            //Console.WriteLine(basePath);
            //enable create folder
            enableButts();

            //Save to BasePath
            //sw = new StreamWriter(basePath+"\\"+"text.txt");
            

        }

        //helper method that reads all current folders
        private void refreshFolderList()
        {
            //Console.WriteLine("ASFDASFDASFDASFD");
            folderList.Items.Clear();
            folderList.Clear();
            
            folderList.View = View.Details;
            folderList.Columns.Add("Folder");
            folderList.Columns[0].Width = this.folderList.Width - 4;
            folderList.HeaderStyle = ColumnHeaderStyle.None;
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
        }

        public void disableButts()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            deleteButton.Enabled = false;
            button5.Enabled = false;
            hideButt.Enabled = false;
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
                    //Console.WriteLine(s);
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
            string newPath = (basePath.ToString() + "\\" + folderList.SelectedItems[0].Text + "\\" + getFileName(currPath));

            // Ensure that the target does not exist. 
            if (File.Exists(newPath))
            {
                MessageBox.Show(this, "File already exists, please rename the current image");
                return;
            }

            //move the file
            imageDisplay.Image = null;
            currImage.Dispose();
            //Console.WriteLine("OldPath " + currPath + " newPath " + newPath);
            File.Move(currPath, newPath);
            //Console.WriteLine("Moved " + getFileName(currPath) + " from " + currPath + " to " + newPath);
            //sw.WriteLine("Moved " + tail + " from " + currPath + " to " + newPath);
            nextImage();
            
        }

        public void nextImage()
        {
            files.RemoveAt(0);
            if (files.Count <= 0)
            {
                if (skipped.Count <= 0)
                {

                    //say end of images
                    folderList.Items.Clear();
                    folderList.Clear();
                    imageDisplay.Image = null;
                    disableButts();
                    // sw.Close();
                    imageName.Text = "";
                    currPath = "";
                    this.Text = "Manual Image Sorter";
                    MessageBox.Show("No images left in folder");
                    return;
                }
                else
                {

                    MessageBox.Show("Ran through all images in folder, displaying remaining images");
                    foreach (string s in skipped)
                    {
                        files.Add(s);
                    }
                    skipped.Clear();
                }
            }
                
                currPath = files[0] as string;
                currImage.Dispose();
                currImage = Image.FromFile(currPath);
                imageDisplay.Image = currImage;
                imageName.Text = getFileName(currPath);
                this.Text = imageName.Text;
                currExtension = getFileType(currPath);
            
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


            currImage = Image.FromFile(currPath);
            imageDisplay.Image = currImage;
            this.Text = imageName.Text;
            //imageName.Text = getFileName(currPath);            
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
                //message box 
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

    }
}
