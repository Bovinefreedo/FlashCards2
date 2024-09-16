using FlashCards2.src.frameworks;
using FlashCards2.src.implimentation;

namespace TestProject1.src.implimentations
{
    [TestClass]
    public class AnwserTest
    {
        [TestMethod]
        public void testCheckAnwser()
        {
            IAnwser anwser = new AnwserStub("42", true);
            IAnwser anwser2 = new AnwserStub("brussel sprouts", false);

            Assert.IsTrue(anwser.checkAnwser(true));
            Assert.IsFalse(anwser.checkAnwser(false));
            Assert.IsTrue(anwser2.checkAnwser(false));
            Assert.IsFalse(anwser2.checkAnwser(true));
        }

        [TestMethod]
        public void testGetAnwser()
        {
            IAnwser anwser = new AnwserStub("42", true);
            IAnwser anwser2 = new AnwserStub("brussel sprouts", false);

            Assert.AreEqual("42", anwser.getAnwser());
            Assert.AreEqual("brussel sprouts", anwser2.getAnwser());
        }
    }
}