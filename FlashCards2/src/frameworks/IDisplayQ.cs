using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.frameworks
{
    public interface IDisplayQ
    {
        public void displayAnwsered();

        public void displayUnanwsered();

        public List<IAnswer> getAnswers();
        public string getQuestion();
        public bool getAnwsered();
        public bool getSelfCheck();
    }
}
