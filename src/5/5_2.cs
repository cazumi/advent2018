using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace advent2018
{
    class five_two
    {
        public static void TaskTwo(){

            var polymer = System.IO.File.ReadAllText(@"src\5\5_1_file.txt");
            //var polymer = "dabAcCaCBAcCcaDA";
            
            List<string> improvedPolymerList = new List<string>();

            var alphabet = new string[] { "aA","bB","cC","dD", "eE","fF","gG","hH","iI","jJ","kK","lL","mM","nN","oO","pP","qQ","rR","sS","tT","uU","vV","wW","xX","yY","zZ" };

            for(int j = 0; j < alphabet.Length; j++){
                var polyChar = alphabet[j].ToCharArray();
                var improvedPolymer = polymer.Replace(polyChar[0].ToString(), "").Replace(polyChar[1].ToString(), "");
                var polymerChars = improvedPolymer.ToCharArray();
                var isEnd = false;

                while(!isEnd){
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
                        string newPolymer = String.Concat(polymerList.Where(c => polymerList.Contains(c)));
                        improvedPolymerList.Add(newPolymer);
                    }
                    polymerChars = polymerList.ToArray();
                }
            }

            var sortedPolymerList = improvedPolymerList.OrderBy(x => x.Length).ThenByDescending(x => x);
            //ende dabCBAcaDA
            Console.WriteLine(String.Join("\n", sortedPolymerList.First().Length)); 
        }
    }
}
