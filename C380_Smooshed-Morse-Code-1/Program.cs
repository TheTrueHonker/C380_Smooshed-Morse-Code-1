using System;
using System.Collections.Generic;
using System.IO;

namespace C380_Smooshed_Morse_Code_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Challenge #380 [Easy] Smooshed Morse Code 1 ----");
            Console.WriteLine();
            Console.WriteLine("Building 'enable1' cache...");

            List<SmooshedMorsecode> morsecodes = new List<SmooshedMorsecode>();
            StreamReader enable1FS = new StreamReader("./enable1.txt");
            while(!enable1FS.EndOfStream)
            {
                morsecodes.Add(new SmooshedMorsecode(enable1FS.ReadLine()));
            }

            Console.WriteLine();
            Console.WriteLine("Excercise 1");
            Console.WriteLine("Getting morsecode with 13 meanings");
            List<string> checkedMorsecodes = new List<string>();
            long counter = 0;
            long matches = 0;
            string answerExercise1 = "";
            foreach(SmooshedMorsecode checkingMorsecode in morsecodes)
            {
                counter++;
                Console.Write("\rChecking {1} of {2}", checkingMorsecode.Text, counter, morsecodes.Count);
                if (checkedMorsecodes.Contains(checkingMorsecode.Morse))
                    continue;
                matches = 0;
                foreach(SmooshedMorsecode morsecode in morsecodes)
                {
                    if (checkingMorsecode.Morse == morsecode.Morse)
                        matches++;
                }
                if (matches == 13)
                {
                    answerExercise1 = checkingMorsecode.Morse;
                    break;
                }
                checkedMorsecodes.Add(checkingMorsecode.Morse);
            }
            Console.WriteLine();
            Console.WriteLine("ANSWER: {0}", answerExercise1);

            Console.WriteLine();
            Console.WriteLine("Excercise 2");
            Console.WriteLine("Getting morsecode with 15 dashes in a row");
            counter = 0;
            SmooshedMorsecode answerExcercise2 = new SmooshedMorsecode("");
            foreach (SmooshedMorsecode morsecode in morsecodes)
            {
                counter++;
                Console.Write("\rChecking {0} of {1}", counter, morsecodes.Count);
                if(morsecode.DashesInRow == 15)
                {
                    answerExcercise2 = morsecode;
                    break;
                }
            }
            Console.WriteLine();
            Console.Write("ANSWER: ");
            answerExcercise2.Print();

            Console.WriteLine();
            Console.WriteLine("Excercise 3");
            Console.WriteLine("Getting prefectly balanced morsecodes");
            List<SmooshedMorsecode> perfectlyBallancedMorseCodes = new List<SmooshedMorsecode>();
            counter = 0;
            foreach(SmooshedMorsecode morsecode in morsecodes)
            {
                counter++;
                Console.Write("\rChecking {0} of {1}", counter, morsecodes.Count);
                if (morsecode.Dashes == morsecode.Dots)
                    perfectlyBallancedMorseCodes.Add(morsecode);
            }
            Console.WriteLine();
            Console.WriteLine("Found the following Morsecodes with 21 letters:");
            foreach(SmooshedMorsecode morsecode in perfectlyBallancedMorseCodes)
            {
                if(morsecode.Text.Length == 21)
                    morsecode.Print();
            }

            Console.WriteLine();
            Console.WriteLine("Excercise 4");
            Console.WriteLine("Getting a 12 letter long palindrome");
            List<SmooshedMorsecode> palindromes = new List<SmooshedMorsecode>();
            counter = 0;
            foreach(SmooshedMorsecode morsecode in morsecodes)
            {
                counter++;
                Console.Write("\rChecking {0} of {1}", counter, morsecodes.Count);
                string reverseMorse = "";
                for(int i = morsecode.Morse.Length-1; i >= 0; i--)
                {
                    reverseMorse += morsecode.Morse[i];
                }
                if (morsecode.Morse == reverseMorse)
                    palindromes.Add(morsecode);
            }
            Console.WriteLine();
            Console.WriteLine("Found the following Morsecodes with a 13-letter word:");
            foreach(SmooshedMorsecode morsecode in palindromes)
            {
                if (morsecode.Text.Length == 13)
                    morsecode.Print();
            }
        }
    }
}
