using System;

namespace advent2018
{
    class one_one
    {
        public static void TaskOne(){
            // Tor 1 Task 1
            string[] frequency = System.IO.File.ReadAllLines(@"src\1\1_1_file.txt");
            int total = 0;
            int solution = 0;
            
            for(int i=0; i<frequency.Length; i++){
               string operation = frequency[i].Substring(0, 1);
               total = Int32.Parse(frequency[i].Substring(1));
                
                switch(operation){
                    case "+":
                        solution = solution + total;
                    break;
                    case "-":
                        solution = solution - total;
                    break;
                }
            }
            Console.WriteLine(solution);
        }
    }
}
