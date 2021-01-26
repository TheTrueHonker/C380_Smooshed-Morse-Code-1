using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C380_Smooshed_Morse_Code_1_Test
{
    [TestClass]
    public class SmooshedMorse
    {
        [TestCategory("Smooshed Morse")]
        [TestMethod]
        public void smorseTest()
        {
            string text = "programmer";
            string expectedMorse = ".--..-.-----..-..-----..-.";

            string morse = C380_Smooshed_Morse_Code_1.Morsecode.SmooshedMorse.smorse(text);

            Assert.AreEqual(expectedMorse, morse);
        }
    }
}
