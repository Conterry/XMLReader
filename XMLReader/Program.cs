﻿using System;
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
            for(int i = 0; i < TegsStr.Length; i++)
            {
                for(int j = 0; j < Line[i].Length; j++)
                {
                    if (Line[i][j] == '<')
                    {
                        int k = 0;
                        while(Line[i][j] != '>')
                        {
                            
                            k++;
                        }
                        TegsStr[j] = Line[i].Substring(j, k);
                    }
                }
            }
        }

    }
}
