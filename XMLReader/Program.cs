using System;
using System.IO;
using System.Collections.Generic;



namespace XMLReader
{
    class Program
    {

        public static List<string> Line = new List<string>();
        public static List<string> TegsStr = new List<string>();

        static void Main(string[] args)
        {
            ReadAll();
            AddTegs();
            for(int i=0; i < TegsStr.Count; i++)
            {
                Console.WriteLine(TegsStr[i]);
            }
        }

        static void ReadAll()
        {
            StreamReader sr = new StreamReader("xml.txt");
            
            while (!sr.EndOfStream)
            {
                Line.Add(sr.ReadLine());
            }
            
        }




        static void AddTegs()
        {
            
            for (int numofstr = 0; numofstr < Line.Count; numofstr++)
            {
                string Text = GetStr(numofstr);
                int a = 0;
                while(a < Text.Length)
                {

                    int start = a, finish = a;
                    while (Text[start] != '<' && a< Text.Length)
                    {
                        start++;
                        a++;
                        
                    }
                    if (a >= Text.Length)
                    {
                        break;
                    }
                    finish = a;
                    while (Text[finish] != '>' && a < Text.Length)
                    {
                        
                        finish++;
                        a++;
                    }
                    if (a == Text.Length - 1) 
                    {
                        
                        if (Text[a] == '>')
                        {
                            string Teststr = Text.Substring(start + 1, finish-start-1);
                            TegsStr.Add(Teststr);
                        }
                        break;
                    }

                    TegsStr.Add(Text.Substring(start + 1, finish-start-1));

                }
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
