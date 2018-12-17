using System;
using System.Linq;

namespace advent2018
{
    class two_two
    {
        public static void TaskTwo(){
	        var ids = System.IO.File.ReadAllLines(@"src\2\2_1_file.txt");
            var rightString = "";

             foreach(string id in ids){
                 var idArray = id.ToCharArray();
                 foreach(string i in ids){
 
                        var iArray = i.ToCharArray();
                     
                        var delta = idArray.Except(iArray);
                        if(delta.Count() == 1){
                            var last_index = 0;
                            var count = 0 ;
                            var count_1 = iArray.Where(w=> idArray.Any(z => w!=z)).Count();
                            var last_index_1 = iArray.Zip(idArray,(m1,m2) => m1 == m2).TakeWhile(b=>b).Count() + 1;


                            for(int x = 0;x<iArray.Length; x++){
                                if(iArray[x] != idArray[x]){
                                    last_index = x;
                                    count ++;
                                }
                            }

                            if (count_1 == 1){
                                var list = iArray.ToList();
                                list.RemoveAt(last_index_1);
                                Console.WriteLine(string.Join("",list.ToArray()));
                                return;
                            }
                        }
                 }
            } 
            
            
            Console.WriteLine(rightString);
        }
    }
}
