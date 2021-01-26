using Microsoft.VisualStudio.TestTools.UnitTesting;
using C380_Smooshed_Morse_Code_1.Morsecode;

namespace C380_Smooshed_Morse_Code_1_Test
{
    [TestClass]
    public class Morse
    {
        [TestCategory("Morse")]
        [TestMethod]
        public void getMorseTest()
        {
            string letter = "z";
            string expectedMorse = "--..";

            string morse = C380_Smooshed_Morse_Code_1.Morsecode.Morse.getMorse(letter);

            Assert.AreEqual(expectedMorse, morse);
        }

        [TestCategory("Morse")]
        [TestMethod]
        public void getMorseCharTest()
        {
            char letter = 'z';
            string expectedMorse = "--..";

            string morse = C380_Smooshed_Morse_Code_1.Morsecode.Morse.getMorse(letter);

            Assert.AreEqual(expectedMorse, morse);
        }

        [TestCategory("Morse")]
        [TestMethod]
        public void getLetterTest()
        {
            string morse = "--..";
            string expectedletter = "z";

            string letter = C380_Smooshed_Morse_Code_1.Morsecode.Morse.getLetter(morse);

            Assert.AreEqual(expectedletter, letter);
        }
    }
}
