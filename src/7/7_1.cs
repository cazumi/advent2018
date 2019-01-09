using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace advent2018
{
    class seven_one
    {
        public static void TaskOne(){

            //var polymer = System.IO.File.ReadAllText(@"src\5\5_1_file.txt");
            string[] textList = new string[] { "C.F","F.E","A.B","B.E","A.D","D.E","C.A" };
            List<string> beforeList = new List<string>();
            List<string> afterList = new List<string>();
            List<string> firstList = new List<string>();
            List<string> nextList = new List<string>();
            string completeString = "";
            var last = false;

            for(int i = 0; i < textList.Length; i++){
                var tList = textList[i].Split(".");
                beforeList.Add(tList[0]);
                afterList.Add(tList[1]);
            }

            var test = beforeList.Except(afterList).ToList();

            for(int i=0; i < beforeList.Count; i++){
               for(int j = 0; j < test.Count; j++){
                    if(beforeList[i] == test[j]){
                        firstList.Add(beforeList[i]+"."+afterList[i]);
                    }else{
                        nextList.Add(beforeList[i]+"."+afterList[i]);
                    }
               }
            }


            //C.A und C.F
            firstList.Sort();



            // A.B und A.D und B.E und D.E und F.E
            nextList.Sort();
            //while(!last){
                    for(int i=0; i < firstList.Count; i++){
                        for(int j=0; j<nextList.Count; j++){
                            var first = firstList[i].Split(".");
                            var next = nextList[j].Split(".");
                            
                            if(completeString.Contains(first[0]) == false || completeString.Contains(first[1]) == false){
                                completeString += first[0];
                            }

                            if(completeString.Contains(next[0]) == false){
                                completeString += next[0];
                            }

                            
                        }
                    }
           //}




            Console.WriteLine(completeString); 
        }
    }
}
