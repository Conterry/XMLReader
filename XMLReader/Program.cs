using System;
using System.IO;

namespace XMLReader
{
    class Program
    {

        public static string[] Line = new string[5];
        public static string[] TegsStr = new string[10];

        static void Main(string[] args)
        {
            ReadAll();
            AddTegs();
            for(int i=0; i < TegsStr.Length; i++)
            {
                Console.WriteLine(TegsStr[i]);
            }
        }

        static void ReadAll()
        {
            StreamReader sr = new StreamReader("xml.txt");
            int i = 0;
            while (!sr.EndOfStream)
            {
                Line[i] = sr.ReadLine();
                i++;
            }
            
        }

        static void AddTegs()
        {
            int numofstr = 0;
            while (numofstr <= Line.Length)
            {
                string Text = GetStr(numofstr);
                int start = 0, finish = 0;
                for (int i = 0; i < TegsStr.Length; i++)
                {

                    
                    while (Text[start] != '<')
                    {
                        start++;
                    }
                    while (Text[finish] != '>')
                    {
                        finish++;
                    }

                    TegsStr[i] = Text.Substring(start + 1, finish - 1);



                }
                numofstr++;
            }
        }


        //TegsStr[j] = Line[i].Substring(j, k);
        

        static string GetStr(int i)
        {
            string TheString = Line[i];
            return TheString;
        }


    }
}
