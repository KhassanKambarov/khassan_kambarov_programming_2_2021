using System;
using System.Linq;

namespace InvoicesManager
{}
    class Program
    {
        static void Main(string[] args)
        {
            string f = "info.txt";
            string path = System.IO.Directory.GetCurrentDirectory()+"/"+f;
            if(System.IO.File.Exists(path)){
                string[] lines = System.IO.File.ReadAllLines(path);
                Console.WriteLine(lines[0]);
                decimal total = 0;
                string[] date = new string[lines.Length-1];
                for(int i=1; i<lines.Length; i++){
                    string[] line = lines[i].Split(';');
                    total += decimal.Parse( line[0]);
                    date[i-1] = line[2];
                    Console.WriteLine(lines[i]);
                }
                var distinctDates = date.Distinct();
                int unique_dates=0;
                foreach(var type in distinctDates){
                    unique_dates++;
                }
                Console.Write("Total expenses:");
                Console.WriteLine(total);
                Console.Write("Dates of payment:");
                Console.WriteLine(unique_dates);
                
            }
            else{
                Console.WriteLine("Invalid input!");
            }
        }
    }

