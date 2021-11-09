using System;
using System.IO;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your horoscope sign:");
            string usersign = Console.ReadLine();
            Console.WriteLine(GetHoroscope(usersign));
        }
        public static string[] ReadHoroscope()
        {
         string filePath = @"C:\Users\opilane\samples\horoscope.txt";
         string[] dataFromFile = File.ReadAllLines(filePath);


            return dataFromFile;
        }
          public static string GetHoroscope(string userinput)
        {
            string[]horoscope =ReadHoroscope();
            string todayhoroscope = "";
           
            foreach (string element in horoscope)
            {

           
               if (element.Contains(userinput))
            
            {
             todayhoroscope = element;
            }

            
            
            }
            return todayhoroscope;
        }



    }
    
}

