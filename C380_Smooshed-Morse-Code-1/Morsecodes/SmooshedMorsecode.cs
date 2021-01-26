using System;
using System.Collections.Generic;
using System.Text;
using C380_Smooshed_Morse_Code_1.Translators;

namespace C380_Smooshed_Morse_Code_1
{
    public class SmooshedMorsecode
    {
        public long Dashes { get; set; }
        public long Dots { get; set; }
        public string Text { get; }
        public string Morse { get; }

        public SmooshedMorsecode(string text)
        {
            Text = text;
            Morse = SmooshedMorseTranslator.smorse(text);
            RecountDashesDots();

        }

        protected void RecountDashesDots()
        {
            long dashesCount = 0;
            long dotsCount = 0;

            for(int i = 0; i < Morse.Length; i++)
            {
                if (Morse[i] == '-')
                    dashesCount++;
                if (Morse[i] == '.')
                    dotsCount++;
            }

            Dashes = dashesCount;
            Dots = dotsCount;
        }
    }
}
