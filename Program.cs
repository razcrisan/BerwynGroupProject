using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;


namespace BerwynGroupProject
{
    class Program {

        class Values {
        public string GUID {get; set;}
        public int Val1 {get; set;}
        public int Val2 {get; set;}
        public string Val3 {get; set;}
        }


        //method to put GUID values into an array
        public Array ArrayOfGUID(string[] args)
        {
            string filePath = @"../BerwynGroupProject/test.csv";
            StreamReader sr = new StreamReader(filePath);
            var lines = new List<string[]>();
            int Row = 0;
            while (!sr.EndOfStream)
            {
                string[] Line = sr.ReadLine().Split(',');
                lines.Add(Line);
                Row++;
                Console.WriteLine(Row);
            }
            var data = lines.ToArray();
            return data;

        }
        
        //method to put Val1 values into an array
        //method to put Val2 values into an array
        //method to put Val3 values into an array

        static void Main(string[] args)
        {
            //first attempt for total lines
            // args = new[] {"../BerwynGroupProject/test.csv"};
            
            int number = 0;
            int largest = 0;
            int csvTotalLines = File.ReadAllLines("../BerwynGroupProject/test.csv").Length;
            Console.WriteLine(csvTotalLines);

            //for loop eventually will use the columns GUID, Val1, Val2, Val3
            for (int i = 0; i < csvTotalLines; i++)
            {
                
                if (csvTotalLines == 0)
                {
                    largest = number;
                }
                else 
                {
                    if (number > largest)
                    largest = number;
                }
            }
            Console.WriteLine(largest);
           
           //second attempt for total lines
            int count = 0;
            string line;
            TextReader totalLines = new StreamReader("../BerwynGroupProject/test.csv");
            while ((line = totalLines.ReadLine()) != null)
            {
                count++;
            }
            Console.WriteLine(count);

            int firstNum = File.ReadAllLines("../BerwynGroupProject/test.csv").Length;

        }
    }
}
