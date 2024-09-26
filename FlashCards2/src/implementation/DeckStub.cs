using FlashCards2.src.frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.implementation
{
    public class DeckStub : IDeck
    {
        List<IQuestion> _questions;
        int _currentQuestion  = 0;
        public DeckStub(List<IQuestion> questions) { 
            _questions = questions;
        }
        public List<string> nextQuestion()
        {
            List<string> shown = new List<string>();
            if (_currentQuestion + 1 < _questions.Count) {
                _currentQuestion++;
                shown = _questions[_currentQuestion].displayQuestion();
            }
            return shown;
        }

        public List<string> previousQuestion()
        {
            List<string> shown = new List<string>();
            if (_currentQuestion - 1 >= 0) {
                _currentQuestion--;
                shown = _questions[_currentQuestion].displayQuestion();
            }
            return shown;
        }

        public void submitAnswer(bool[] answer)
        {
            return;
        }
    }
}
