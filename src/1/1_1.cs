using System;
using System.IO;
using System.Linq;

namespace advent2018
{
    class one_one
    {
        public static void TaskOne(){
            // Tor 1 Task 1
            var frequencies = File.ReadAllLines(@"src\1\1_1_file.txt").Select(o => Int32.Parse(o));
            int total = 0;
            
           foreach(int f in frequencies){
               total += f;
           }
            Console.WriteLine(total);
        }
    }
}
