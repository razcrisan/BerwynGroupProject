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
        //colums of the csv file

        class Values {
        public string GUID {get; set;}
        public int Val1 {get; set;}
        public int Val2 {get; set;}
        public string Val3 {get; set;}
        public string GetCsvContent {get; set;}
        }

        // method to put GUID values into an array
        public Array ArrayOfGUID(string[] args)
        {
            string filePath = @"../BerwynGroupProject/test.csv";
            StreamReader sr = new StreamReader(filePath);
            var lines = new List<string[]>();
            int Row = 0;
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Trim('"').Split(',');
                Values val = new Values();
                val.GUID = line[0].Trim();
                val.Val1 = line[1].Trim();
                Row++;
                Console.WriteLine(Row);
                
            }
            
            var DataGUID = lines.ToArray();
            return DataGUID;
            
        }



        //method to put Val1 values into an array
        //method to put Val2 values into an array
        //method to put Val3 values into an array

        static void Main(string[] args)
        {
            
            int number = 0;
            int largest = 0;
            int csvTotalLines = File.ReadAllLines("../BerwynGroupProject/test.csv").Length;
            Console.WriteLine(csvTotalLines);
            
            //for loop eventually will use the columns , Val1, Val2,  to find largest value
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


            //Finds the first line of the array the Header for each column and outputs to console.
            
            
            string filePath = @"../BerwynGroupProject/test.csv";
            StreamReader sr = new StreamReader(filePath);
            while (!sr.EndOfStream)
            {
            TextReader csvArray = File.OpenText("../BerwynGroupProject/test.csv");
            string csvArrayLine = csvArray.ReadLine();
            string[] csvtokens = csvArrayLine.Split(',');
            System.Console.WriteLine(csvArrayLine);
            }
            System.Console.WriteLine(csvTotalLines);
            
            

         
            
        }
    }
}
// }
//         public string[] GetCsvContent(string iFileName)
//         {
//             List<string> oCsvContent = new List<string>();
//             using (FileStream lFileStream = 
//             new FileStream("../BerwynGroupProject/test.csv", FileMode.Open, FileAccess.Read))
//             {
//                 StringBuilder lFileContent = new StringBuilder();
//                 using (StreamReader lReader = new StreamReader(lFileStream))
//                 {
//                     // flag if a double quote is found
//                     bool lContainsDoubleQuotes = false; 
//                     // a string for the csv value
//                     string lCsvValue = "";
//                     // loop through the file until you read the end
//                     while (!lReader.EndOfStream)
//                     {
//                     // stores each line in a variable
//                     string lCsvLine = lReader.ReadLine();
//                     // for each character in the line...
//                     foreach (char lLetter in lCsvLine)
//                     {
//                     // check if the character is a double quote
//                     if (lLetter == '"')
//                     {
//                         if (!lContainsDoubleQuotes)
//                         {
//                             lContainsDoubleQuotes = true;
//                         }
//                         else
//                         {
//                             lContainsDoubleQuotes = false;
//                         }
//                     }
//                     // AND it's not within a double quote..
//                     if (lLetter == ',' && !lContainsDoubleQuotes)
//                     {
//                         // add our string to the array
//                         oCsvContent.Add(lCsvValue);
//                         // null out our string
//                         lCsvValue = "";
//                     }
//                     else
//                     {
//                         // add the character to our string
//                         lCsvValue += lLetter;
//                     }
//                 }
//             }
//         }
//     }
//     return oCsvContent.ToArray();
// }