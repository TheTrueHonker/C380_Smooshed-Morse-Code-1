using System;
using System.Collections.Generic;
using System.Text;

namespace C380_Smooshed_Morse_Code_1.Morsecode
{
    public static class SmooshedMorse
    {
        public static string smorse(string text)
        {
            string smoothedMorse = "";
            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] == ' ')
                {
                    smoothedMorse += " ";
                    continue;
                }
                smoothedMorse += Morse.getMorse(text[i]);
            }
            return smoothedMorse;
        }
    }
}
