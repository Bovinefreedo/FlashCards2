using FlashCards2.src.frameworks;
using FlashCards2.src.implementation;

namespace TestProject1.src.implementations
{
    [TestClass]
    public class AnswerTest
    {

        [TestMethod]
        public void testCheckAnswer()
        {
            IAnswer answer = new AnswerStub("42", true);
            IAnswer answer2 = new AnswerStub("brussel sprouts", false);

            Assert.IsTrue(answer.checkAnswer(true));
            Assert.IsFalse(answer.checkAnswer(false));
            Assert.IsTrue(answer2.checkAnswer(false));
            Assert.IsFalse(answer2.checkAnswer(true));
        }

        [TestMethod]
        public void testGetAnswer()
        {
            IAnswer answer = new AnswerStub("42", true);
            IAnswer answer2 = new AnswerStub("brussel sprouts", false);

            Assert.AreEqual("42", answer.getAnswer());
            Assert.AreEqual("brussel sprouts", answer2.getAnswer());
        }
    }
}