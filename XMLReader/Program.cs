using System;
using System.IO;

namespace XMLReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader();
        }

        static void Reader()
        {
            StreamReader sr = new StreamReader("xml.txt");
            while (!sr.EndOfStream)
            {
                string a = sr.ReadLine();
                Console.WriteLine(a);
            }
            
        }

    }
}
