using System;
namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File Operations!");
            string filepath = @"E:\File Operations\File_Operations\FileOperations\FileOperations\Files\Example.txt";
            string newfilepath = @"E:\File Operations\File_Operations\FileOperations\FileOperations\Files\TextFile1.txt";
            Operations.FileExists(filepath);
            Operations.ReadLines(filepath);
            Operations.ReadText(filepath);
            Operations.FileCopy(filepath, newfilepath);


        }
    }
}
