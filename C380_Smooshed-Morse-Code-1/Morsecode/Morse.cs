using System;
using System.Collections.Generic;
using System.Text;

namespace C380_Smooshed_Morse_Code_1.Morsecode
{
    public class Morse
    {
        private static string morse = ".- -... -.-. -.. . ..-. --. .... .. .--- -.- .-.. -- -. --- .--. --.- .-. ... - ..- ...- .-- -..- -.-- --..";
        private static string alphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z";

        public static string getMorse(string letter)
        {
            if (letter.Length < 1 || letter.Length > 1)
                return "";

            string[] morseArray = morse.Split(' ');
            string[] alphabetArray = alphabet.Split(' ');

            for (int i = 0; i < alphabetArray.Length; i++)
            {
                if (alphabetArray[i] == letter)
                {
                    return morseArray[i];
                }
            }

            return "";
        }

        public static string getLetter(string morseLetter)
        {
            if (morseLetter.Length < 1 || morseLetter.Length > 4)
                return "";

            string[] morseArray = morse.Split(' ');
            string[] alphabetArray = alphabet.Split(' ');

            for (int i = 0; i < morseArray.Length; i++)
            {
                if (morseArray[i] == morseLetter)
                {
                    return alphabetArray[i];
                }
            }

            return "";
        }

        public static string getMorse(char letter)
        {
            return getMorse(letter.ToString());
        }
    }
}
