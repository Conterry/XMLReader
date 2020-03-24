using System;
using System.IO;

namespace XMLReader
{
    class Program
    {

        public string[] Line = new string[7];


        static void Main(string[] args)
        {
            Reader();
        }

        static void Reader()
        {
            StreamReader sr = new StreamReader("xml.txt");
            int i = 0;
            while (!sr.EndOfStream)
            {
                Line[i] = sr.ReadLine();
                i++;
            }
            
        }

    }
}
