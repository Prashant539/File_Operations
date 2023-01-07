using System;
namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File Operations!");
            string filePath = @"E:\File Operations\File_Operations\FileOperations\FileOperations\Files\Example.txt";
            Operations.FileExists(filePath);
            Operations.ReadLines(filePath);
            Operations.ReadText(filePath);
        }
    }
}
