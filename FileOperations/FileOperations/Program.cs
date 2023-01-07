using System;
namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File Operations!");
            string filePath = @"E:\Self Practice Problem\FileOperations\FileOperations\Files\Example.txt";
            Operations.FileExists(filePath);
        }
    }
}
