using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTranser
{
    class FileCopy
    {
        static void Main(string[] args)
        {
            string getFile = "test.txt";
            string rootPath = @"C:\Users\Public\SourceFolder";
            string destPath = @"C:\Users\Public\SourceFolder\SubFolder";

            string sourceFile = System.IO.Path.Combine(rootPath, getFile);
            string destFile = System.IO.Path.Combine(destPath, getFile);

            if (!System.IO.Directory.Exists(destPath))
            {
                System.IO.Directory.CreateDirectory(destPath);
            }

            System.IO.File.Copy(sourceFile, destFile, true);

         
            if (System.IO.Directory.Exists(rootPath))
            {
                string[] files = System.IO.Directory.GetFiles(rootPath);

                foreach (string s in files)
                {
                    getFile = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(destPath, getFile);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }

            Console.WriteLine("File(s) have been copied to SubFolder");
            Console.ReadKey();
        }
    }
}
