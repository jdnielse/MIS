using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Manual_Image_Sorter
{
    public class NewFolder
    {
        static void MakeNewFolder()
        {
            string folderName = @"C:\Top-Level Folder";
        
            string pathString = System.IO.Path.Combine(folderName, "SubFolder");

            string pathString2 = @"C:\Top-Level Folder\SubFolder2";

            System.IO.Directory.CreateDirectory(pathString);

            string fileName = System.IO.Path.GetRandomFileName();

            pathString = System.IO.Path.Combine(pathString, fileName);

            Console.WriteLine("Path to my file: {0}\n", pathString);

            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", fileName);
                return;
            }

        }
    }
}
