using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stringlist = new List<string>();
            stringlist.Add("Ramil");
            stringlist.Add("Sadiq");
            stringlist.Add("Cavid");
            stringlist.Add("Elnur");
            stringlist.Add("Faxri");
            stringlist.Add("Elvin");
            stringlist.Add("Fariz");




            var result = stringlist.FindAll(m => m != "Cavid");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static bool CheckWord(string word)
        {
            return word != "Cavid";
        }

        public static string CheckWords(Predicate<string> predicate, string[] words)
        {
            var name = "Cavid";
            foreach (var item in words)
            {
                if (predicate(item))
                {
                    Console.WriteLine(item);
                }
            }
            return name;
        }
        
    }  
}
