using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    public class Operations
    {
        public static void FileExists(string filepath)
        {
            if (File.Exists(filepath))
                Console.WriteLine("File Exists");
            else
                Console.WriteLine("File Not Exists");
        }
        public static void ReadLines(string filepath)
        {
            if (File.Exists(filepath))
            {
                string[] lines = File.ReadAllLines(filepath);
                foreach (var data in lines)
                {
                    Console.WriteLine(data);
                }
            }
        }
        public static void ReadText(string filepath)
        {
            if (File.Exists(filepath))
            {
                string lines = File.ReadAllText(filepath);
                Console.WriteLine(lines);
            }
            else
                Console.WriteLine("File Not Exists");
        }
        public static void FileCopy(string filepath)
        {
            string newfilepath = @"E:\File Operations\File_Operations\FileOperations\FileOperations\Files\CopyFile.txt";
            if (File.Exists(filepath))
            {
                File.Copy(filepath, newfilepath, true);

            }
            else
                Console.WriteLine("File Not Exists");

        }
        public static void FileDelete(string newfilepath)
        {
            if (File.Exists(newfilepath))
            {
                File.Delete(newfilepath);

            }
            else
                Console.WriteLine("File Not Exists");
        }

    }
}

