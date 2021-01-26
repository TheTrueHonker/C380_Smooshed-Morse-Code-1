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
            string answerExercise2_Morse = "";
            string answerExercise2_Text = "";
            foreach (SmooshedMorsecode morsecode in morsecodes)
            {
                counter++;
                Console.Write("\rChecking {0} of {1}", counter, morsecodes.Count);
                if(morsecode.DashesInRow == 15)
                {
                    answerExercise2_Text = morsecode.Text;
                    answerExercise2_Morse = morsecode.Morse;
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("ANSWER: {0}: {1}", answerExercise2_Text, answerExercise2_Morse);
        }
    }
}
