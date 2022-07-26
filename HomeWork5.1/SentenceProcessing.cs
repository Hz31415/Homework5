using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5._1
{
    internal class SentenceProcessing
    {
        public static string[] Splitter(string inputStr)
        {
            string[] words = inputStr.Split(' ');
            return words;
        }

        public static string[] ReversWords(string inputPhrase)
        {
            return (string[])Splitter(inputPhrase).Reverse();
        }

        public static void WordsArrOut(string[] strArray)
        { 
            foreach(string str in strArray)
                Console.WriteLine(str);
        }


    }
}
