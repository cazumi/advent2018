using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace advent2018
{
    class one_two
    {
        public static void TaskTwo(){
            
                        // Tor 1 Task 1
            var frequencies = File.ReadAllLines(@"src\1\1_1_file.txt").Select(o => Int32.Parse(o));
            var totalList = new List<int>(); 
            var total = 0;
            var gotTwice = false;
            
        while(!gotTwice){ 
           foreach(int f in frequencies){
               total += f;
               gotTwice = totalList.Any(i => i == total);
               if(gotTwice){
                   break;
               }
               
               totalList.Add(total);
           }
        }
            Console.WriteLine(total);
        }
    }
}
