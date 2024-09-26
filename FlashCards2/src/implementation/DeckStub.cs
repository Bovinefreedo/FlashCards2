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
        IDisplayQ _shown; 
        public DeckStub(List<IQuestion> questions) { 
            _questions = questions;
            _shown = _questions[0].displayQuestion();
        }
        public IDisplayQ nextQuestion()
        {
            if (_currentQuestion + 1 < _questions.Count) {
                _currentQuestion++;
                 _shown = _questions[_currentQuestion].displayQuestion();
            }
            return _shown;
        }

        public IDisplayQ previousQuestion()
        {
            if (_currentQuestion - 1 >= 0) {
                _currentQuestion--;
                _shown = _questions[_currentQuestion].displayQuestion();
            }
            return _shown;
        }

        public void submitAnswer(bool[] answer)
        {
            return;
        }
    }
}
