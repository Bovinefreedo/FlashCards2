using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlashCards2.src.frameworks;
using FlashCards2.src.implementation;

namespace TestProject1.implementations
{
    [TestClass]
    public class DeckTest
    {
        public DeckStub SetupDeck()
        {
            List<IAnswer> answer = new List<IAnswer> { new AnswerStub("42", true) };
            List<IAnswer> answer2 = new List<IAnswer> { new AnswerStub("brussel sprouts", false) };

            QuestionStub question = new QuestionStub("what is the answer of life, the universe and everything?", answer);
            QuestionStub question2 = new QuestionStub("what is for dinner?", answer);

            List<IQuestion> questions = new List<IQuestion>();

            DeckStub deck = new DeckStub(questions);

            return deck;
        }

    }
}
