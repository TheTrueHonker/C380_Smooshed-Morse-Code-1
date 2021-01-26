using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C380_Smooshed_Morse_Code_1_Test.Translators
{
    [TestClass]
    public class SmooshedMorseTranslator
    {
        [TestCategory("Smooshed Morse")]
        [TestMethod]
        public void smorseTest()
        {
            string text = "programmer";
            string expectedMorse = ".--..-.-----..-..-----..-.";

            string morse = C380_Smooshed_Morse_Code_1.Translators.SmooshedMorseTranslator.smorse(text);

            Assert.AreEqual(expectedMorse, morse);
        }
    }
}
