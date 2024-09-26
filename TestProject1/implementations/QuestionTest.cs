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

            //QuestionStub question = new QuestionStub("what is the answer of life, the universe and everything?", answer);
            //QuestionStub question2 = new QuestionStub("what is for dinner?", answer);

            List<QuestionStub> questions = new List<QuestionStub>();
            //questions.Add(question);
            //questions.Add(question2);
            return questions;

        }
        //test two Questions
        //test null case, deal with length 0 of anwsers
        [TestMethod]
        public void testDisplayQuestion()
        {

        }

        [TestMethod]
        public void testSubmitAnswerQuestion()
        {

        }
    }
}
