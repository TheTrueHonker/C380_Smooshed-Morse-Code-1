using System;
using System.Collections.Generic;
using System.Text;
using C380_Smooshed_Morse_Code_1.Translators;

namespace C380_Smooshed_Morse_Code_1
{
    public class SmooshedMorsecode
    {
        public long Dashes { get; protected set; }
        public long DashesInRow { get; protected set; }
        public long Dots { get; protected set; }
        public string Text { get; }
        public string Morse { get; }

        public SmooshedMorsecode(string text)
        {
            Text = text;
            Morse = SmooshedMorseTranslator.smorse(text);
            RecountDashesDots();

        }

        public void Print()
        {
            Console.WriteLine("{0}: {1}", Text, Morse);
        }

        protected void RecountDashesDots()
        {
            long dashesCount = 0;
            long dotsCount = 0;

            char previosChar = ' ';
            long longestDashInRow = 0;
            long dashesInRowTemp = 0;

            for(int i = 0; i < Morse.Length; i++)
            {
                if (Morse[i] == '-')
                {
                    dashesCount++;
                    if(previosChar == '-')
                    {
                        dashesInRowTemp++;
                    }
                    else
                    {
                        previosChar = '-';
                        dashesInRowTemp = 1;
                    }
                    continue;
                }
                if (Morse[i] == '.')
                {
                    dotsCount++;
                    if(previosChar == '-')
                    {
                        if (dashesInRowTemp > longestDashInRow)
                            longestDashInRow = dashesInRowTemp;
                    }
                    previosChar = '.';
                }
            }

            Dashes = dashesCount;
            Dots = dotsCount;
            DashesInRow = longestDashInRow;
        }
    }
}
