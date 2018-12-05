using System;
using System.Linq;

namespace advent2018
{
    class three_one
    {
        public static void TaskThree(){
	     
           string[] rectangle = System.IO.File.ReadAllLines(@"src\3\3_1_file.txt");
           string[,] fabric = new string[1000, 1000];

           int rowLength = fabric.GetLength(0);
           int colLength = fabric.GetLength(1);
           var counter = 0;
            
           for(int i=0; i<rectangle.Length-1; i++){
               
               var source = rectangle[i].Split();
               var location = source[2].Split(',');
               var size = source[3].Split('x');

               var id = source[0].Substring(1);
               var horizontalLocation = Int32.Parse(location[0]);
               var verticalLocation = Int32.Parse(location[1].Remove(location[1].Length - 1));
               var horizontal = Int32.Parse(size[0]);
               var vertical = Int32.Parse(size[1]);
               
               for(int j=0; j<horizontal; j++){
                   
                   var h = horizontalLocation;
                   var v = verticalLocation;
                   
                   for(int k=0; k<vertical; k++){
                       if(fabric[horizontalLocation, v] == null){
                        fabric[horizontalLocation, v] = id;
                        }
                        else{
                            counter++;
                            fabric[horizontalLocation, v] = "x";

                        }
                        v++;
                   }
                   horizontalLocation++;  
               }
            }
          Console.Write(counter);
        }
    }
}
