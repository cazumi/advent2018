using System;
using System.Linq;
using System.Collections.Generic;

namespace advent2018
{
    class four_one
    {
        public static List<guards> guards = new List<guards>();
        public static List<int> sleepList = new List<int>();
        public static List<int> awakeList = new List<int>();

        public static void TaskFour(){
	     
           //string[] rectangle = System.IO.File.ReadAllLines(@"src\4\4_1_file.txt");
           string[] guardsList = new string[]{"[1518-11-01 00:00] Guard #10 begins shift","[1518-11-01 00:05] falls asleep","[1518-11-01 00:25] wakes up","[1518-11-01 00:30] falls asleep","[1518-11-01 00:55] wakes up","[1518-11-01 23:58] Guard #99 begins shift","[1518-11-02 00:40] falls asleep","[1518-11-02 00:50] wakes up","[1518-11-03 00:05] Guard #10 begins shift","[1518-11-03 00:24] falls asleep","[1518-11-03 00:29] wakes up","[1518-11-04 00:02] Guard #99 begins shift","[1518-11-04 00:36] falls asleep","[1518-11-04 00:46] wakes up","[1518-11-05 00:03] Guard #99 begins shift","[1518-11-05 00:45] falls asleep","[1518-11-05 00:55] wakes up"};
            var id = 0;
            var date = "";

           for(int i=0; i<guardsList.Length; i++){
               var guardAttribute = guardsList[i].Split();
               date = guardAttribute[0].Substring(1);
               var time = guardAttribute[1].Remove(guardAttribute[1].Length - 1);
               var sleep = 0;
               var awake = 0;
               var guardStatus = "";

               if(guardsList[2] == "Guard"){
                   id = Int32.Parse(guardsList[3].TrimEnd());

               }else{
                   guardStatus = guardsList[2] + guardsList[3];
               }

               if(!guards.Any()){
                  createGuard(id, date);
               }
               else{
                   foreach(var g in guards)
                   {
                       if(g.id != id || g.date != date){
                           createGuard(id, date);
                       }else{
                           
                       }
                   }
               }
           }
 
         // Console.Write(counter);
        }

        private void isAwake(){

        }

        private static void createGuard(int id, string date){
            guards guard = new guards();
            guard.id = id;
            guard.date = date;
            guards.Add(guard);
        }
    }
}
