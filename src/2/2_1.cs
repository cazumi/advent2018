using System;
using System.Linq;

namespace advent2018
{
    class two_one
    {
        public static void TaskTwo(){
	        string[] id = System.IO.File.ReadAllLines(@"src\2\2_1_file.txt");
            int countTwice = 0;
            int countThree = 0;
            int total = 0;
            var idString = "";
      
             for(int i=0; i < id.Length; i++){
                idString = id[i];

                var two = idString .GroupBy(c => c).Where(c => c.Count() == 2).Select(c => new { charCount = c.Count()});
                var three = idString .GroupBy(c => c).Where(c => c.Count() == 3).Select(c => new { charCount = c.Count()});
                
                if(two.Count() >= 1){
                    countTwice++;
                }
                if(three.Count() >= 1){
                    countThree++;
                }
            } 
            
            total = countTwice * countThree;
            Console.WriteLine(string.Join(",", total));
        }
    }
}
