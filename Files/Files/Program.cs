using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sourcePath = @"c:\projetos\file1.txt";
            string targetPath = @"c:\projetos\file2.txt";

            try
            {
                //https://learn.microsoft.com/en-us/dotnet/api/system.io.fileinfo?view=net-9.0#methods
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}