using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("0", "zero");
            hashtable.Add("1", "one");
            hashtable.Add("2", "two");
            hashtable.Add("3", "three");
            hashtable.Add("4", "four");
            hashtable.Add("5", "five");
            hashtable.Add("6", "six");
            hashtable.Add("7", "seven");
            hashtable.Add("8", "eight");
            hashtable.Add("9", "nine");


            string variable = "072542795409752195734ö96078436219409";

            foreach(char c in variable){
                string newVariable = c.ToString();
                if (hashtable.ContainsKey(newVariable)){
                    Console.WriteLine(hashtable[newVariable]);
                }
            }

            Console.ReadKey();
        }
    }
}
