using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace BerwynGroupProject
{
    class Program {

        class Values {
        public string GUID {get; set;}
        public int Val1 {get; set;}
        public int Val2 {get; set;}
        public string Val3 {get; set;}
        

        public static Values FromLine(string line)
        {
            var data = line.Split(',');

            return new Values()
            {
                GUID = data[0],
                Val1 = int.Parse(data[1]),
                Val2 = int.Parse(data[2]),
                Val3 = data[3]
            };
        }
     
        }


        static void Main(string[] args)
        {
            args = new[] {"../BerwynGroupProject/test.csv"};

            var values = ReadValues(args[0]);
    
            Console.WriteLine(values);
        }
        
       
       
        static IList<Values> ReadValues(string path)
        {
            var list = new List<Values>();
            foreach(var line in File.ReadLines(path))
            {
                list.Add(Values.FromLine(line));
            }
            return list;
        }
        
    }
}
















        // struct Vertex
        // {
        //     private int _x, _y, _z;

        //     public Vertex (int x, int y, int z)
        //     {
        //         _x = x;
        //         _z = z;
        //         _y = y;
        //     }
        //     public int X {get {return _x;}}
        //     public int Y {get {return _y;}}
        //     public int Z {get {return _z;}}

        //     public override string ToString()
        //     {
        //         return String.Format("{0}, {1}, {2}", _x, _y, _z);
        //     }

        // public static bool Parse(string text, out Vertex vertex)
        // {
        //     const string PATTERN = @"(?<X>\d+), (?<Y>\d+), (?<Z>\d+)";
        //     Match match = Regex.Match(text, PATTERN);

        //     if (match.Success)
        //     {
        //         int x = int.Parse(match.Groups["X"].Value);
        //         int y = int.Parse(match.Groups["Y"].Value);
        //         int z = int.Parse(match.Groups["Z"].Value);
        //         vertex = new Vertex (x, y, z);
        //         return true;
        //     }
        //     else
        //     {
        //         vertex = new Vertex();
        //         return false;
        //     }
        //}
    //}
//}
