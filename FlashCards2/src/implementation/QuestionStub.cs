using FlashCards2.src.frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.implementation
{
    public class QuestionStub : IQuestion
    {
        private string _question;
        private List<IAnswer> _anwsers;
        private bool _answered = false;
        private bool _selfCheck;
        private IDisplayStrategy _strategy;
        public QuestionStub(string question, List<IAnswer> answers, bool selfCheck, IDisplayStrategy strategy) {
            _question = question;
            _anwsers = answers;
            _selfCheck = selfCheck;
            _strategy = strategy;
        }
        public IDisplayQ displayQuestion()
        {
            return IDisplayQ disObj = new DisplayQImpl
            {
                question = _question,
                anwser = _anwsers,
                anwsered = _answered,
                selfCheck = _selfCheck,
                display = _strategy
            };
        }

        public void submitAnswer(List<bool> answers)
        {
            Console.WriteLine(answers[0]);
            return;
        }


        public bool wasCorrect()
        {
            return true;
        }
    }
}
