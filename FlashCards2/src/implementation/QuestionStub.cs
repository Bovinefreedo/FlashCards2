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
        public QuestionStub(string question, List<IAnswer> answers) {
            _question = question;
            _answers = answers;
        }
        public List<string> displayQuestion()
        {
            List<string> display = new List<string>();
            display.Add(_question);
            return display;
        }

        public bool submitAnswer(List<bool> answers)
        {
            Console.WriteLine(answers[0]);
            return true;
        }

        public bool wasCorrect()
        {
            return true;
        }
    }
}
