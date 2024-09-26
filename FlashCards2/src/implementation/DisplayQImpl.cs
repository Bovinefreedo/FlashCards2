using FlashCards2.src.frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.implementation
{
    public class DisplayQImpl : IDisplayQ
    {
        public string question { get; set; } = string.Empty;
        public List<IAnswer> anwser { get; set; } = new List<IAnswer>();
        public bool anwsered { get; set; }
        public bool selfCheck { get; set; }
        public IDisplayStrategy display { get; set; }
        public void displayAnwsered()
        {
            display.displayAnwser(this);
        }

        public void displayUnanwsered()
        {
            display.displayQuestion(this);
        }

        public List<IAnswer> getAnswers()
        {
            return anwser;
        }

        public bool getAnwsered()
        {
            return anwsered;
        }

        public string getQuestion()
        {
            return question;
        }

        public bool getSelfCheck()
        {
            return selfCheck;
        }
    }
}
