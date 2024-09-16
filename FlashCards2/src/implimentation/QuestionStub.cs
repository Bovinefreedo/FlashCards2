using FlashCards2.src.frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.implimentation
{
    public class QuestionStub : IQuestion
    {
        private string _question;
        private List<IAnwser> _anwsers;
        public QuestionStub(string question, List<IAnwser> anwsers) {
            _question = question;
            _anwsers = anwsers;
        }
        public List<string> displayQuestion()
        {
            List<string> display = new List<string>();
            display.Add(_question);
            return display;
        }

        public bool submitAnwser(List<bool> anwsers)
        {
            Console.WriteLine(anwsers[0]);
            return true;
        }

        public bool wasCorrect()
        {
            throw new NotImplementedException();
        }
    }
}
