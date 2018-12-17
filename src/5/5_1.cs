using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace advent2018
{
    class five_one
    {
        public static void TaskOne(){

            var polymer = System.IO.File.ReadAllText(@"src\5\5_1_file.txt");
            //var polymer = "dabAcCaCBAcCcaDA";
            var polymerChars = polymer.ToCharArray();
            var isEnd = false;

            while(!isEnd){
                var hasCanges = false;
                var i = 0;
                var polymerLength = polymerChars.Length -1;
                List<char> polymerList = new List<char>();
                for(i = 0; i < polymerChars.Length; i++){
                    if(polymerLength == i){
                        polymerList.Add(polymerChars[i]);
                    }
                    else if (i != 0){
                        if(string.Equals(polymerChars[i].ToString(), polymerChars[i+1].ToString(), StringComparison.CurrentCultureIgnoreCase)){
                            if(polymerChars[i] == polymerChars[i+1]){
                                polymerList.Add(polymerChars[i]);
                            }
                            else{
                                i++;
                            }
                        }else{
                            polymerList.Add(polymerChars[i]);
                        }
                    }
                    else{
                         if(string.Equals(polymerChars[i].ToString(), polymerChars[i+1].ToString(), StringComparison.CurrentCultureIgnoreCase)){
                            if(polymerChars[i] == polymerChars[i+1]){
                                polymerList.Add(polymerChars[i]);
                            }
                        }else{
                            polymerList.Add(polymerChars[i]);
                        }
                    }
                }
                if(polymerList.SequenceEqual(polymerChars)){
                    isEnd = true;
                }
                polymerChars = polymerList.ToArray();
            }

            //ende dabCBAcaDA
            Console.WriteLine(String.Join("\n", polymerChars.Count())); 
        }
    }
}
