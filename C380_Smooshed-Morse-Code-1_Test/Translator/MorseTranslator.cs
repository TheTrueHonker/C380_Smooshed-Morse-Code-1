using Microsoft.VisualStudio.TestTools.UnitTesting;
using C380_Smooshed_Morse_Code_1.Translators;

namespace C380_Smooshed_Morse_Code_1_Test.Translators
{
    [TestClass]
    public class MorseTranslator
    {
        [TestCategory("Morse")]
        [TestMethod]
        public void getMorseTest()
        {
            string letter = "z";
            string expectedMorse = "--..";

            string morse = C380_Smooshed_Morse_Code_1.Translators.MorseCharTranslator.getMorse(letter);

            Assert.AreEqual(expectedMorse, morse);
        }

        [TestCategory("Morse")]
        [TestMethod]
        public void getMorseCharTest()
        {
            char letter = 'z';
            string expectedMorse = "--..";

            string morse = C380_Smooshed_Morse_Code_1.Translators.MorseCharTranslator.getMorse(letter);

            Assert.AreEqual(expectedMorse, morse);
        }

        [TestCategory("Morse")]
        [TestMethod]
        public void getLetterTest()
        {
            string morse = "--..";
            string expectedletter = "z";

            string letter = C380_Smooshed_Morse_Code_1.Translators.MorseCharTranslator.getLetter(morse);

            Assert.AreEqual(expectedletter, letter);
        }
    }
}
