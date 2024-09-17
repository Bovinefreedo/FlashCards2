using FlashCards2.src.frameworks;
using FlashCards2.src.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.implementations
{
    [TestClass]
    public class QuestionTest
    {
        public List<QuestionStub> setup()
        {
            List<IAnswer> answer = new List<IAnswer> { new AnswerStub("42", true) };
            List<IAnswer> answer2 = new List<IAnswer> { new AnswerStub("brussel sprouts", false) };

            QuestionStub question = new QuestionStub("what is the answer of life, the universe and everything?", answer);
            QuestionStub question2 = new QuestionStub("what is for dinner?", answer);

            List<QuestionStub> questions = new List<QuestionStub>();
            questions.Add(question);
            questions.Add(question2);
            return questions;

        }
        [TestMethod]
        public void testDisplayQuestion()
        {
            List<QuestionStub> questions = setup();
            List<string> question = new List<string> { "what is the answer of life, the universe and everything?", "what is for dinner?" };

            Assert.AreEqual(question[0], questions[0].displayQuestion()[0]);
            Assert.AreEqual(question[1], questions[1].displayQuestion()[0]);
        }

        [TestMethod]
        public void testSubmitAnswerQuestion()
        {
            List<QuestionStub> questions = setup();

            Assert.IsTrue(questions[0].submitAnswer(new List<bool> { false }));
            Assert.IsTrue(questions[1].submitAnswer(new List<bool> { true }));
        }

        //Don't know how to test this
        [TestMethod]
        public void testWasCorrect()
        {

        }
    }
}
