using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class Operation
    {
        public static void FileExist(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("File is exist");
            }
        }
        public static void ReadAllLines(string path)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (var data in lines)
            {
                Console.WriteLine(data + " ");
            }
        }
        public static void ReadAllText(string path)
        {
            string line = File.ReadAllText(path);
            Console.WriteLine(line + " ");
        }
        public static void CopyText(string path, string newpath)
        {
            File.Copy(path, newpath);
        }
        public static void Delete(string newpath)
        {
            File.Delete(newpath);
        }
        public static void DisplayFile(string path)
        {
            StreamReader read = null;
            try
            {
                using (read = new StreamReader(path))
                {
                    var data = read.ReadToEnd();
                    foreach (var text in data)
                    {
                        Console.WriteLine(text + " ");
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}