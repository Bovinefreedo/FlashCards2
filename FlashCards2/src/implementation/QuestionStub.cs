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
        private List<IAnswer> _answers;
        private bool _answered = false;
        public QuestionStub(string question, List<IAnswer> answers) {
            _question = question;
            _answers = answers;
        }
        public List<string> displayQuestion()
        {
            if (_answered) return showUnanswered();
            else return showUnanswered();
        }

        public List<string> showAnswered()
        {
            List<string> display = new List<string>();
            display.Add(_answers[0].getAnswer());
            return display;
        }

        public List<string> showUnanswered()
        {
            List<string> display = new List<string>();
            display.Add(_question);
            return display;
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
