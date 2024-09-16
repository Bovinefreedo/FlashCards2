using FlashCards2.src.frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.implementation
{
    public class AnswerStub : IAnswer
    {
        private string _answer;
        private bool _correct;
        public AnswerStub(string answer, bool correct) {
            _answer = answer;
            _correct = correct;
        }
        public bool checkAnswer(bool answer)
        {
            return _correct == answer;
        }

        public string getAnswer()
        {
            return _answer;
        }
    }
}
