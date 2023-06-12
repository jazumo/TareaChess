// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.IO;

class Program
{
    public static void Main()
    {
        string path = @"C:\Users\JOSE ZUNIGA\Desktop\trabajos U\Aplicaciones de Vanguardia\Repo\Chess/TestFile.txt";
        if (!File.Exists(path))
        {
            /*
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
            */
            Console.WriteLine("File could not be found");
        }

        // Open the file to read from.
        using (StreamReader sr = File.OpenText(path))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}