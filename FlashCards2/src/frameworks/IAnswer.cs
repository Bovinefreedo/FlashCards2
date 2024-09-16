using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.frameworks
{
    public interface IAnswer
    {
        public bool checkAnswer(bool answer);
        public string getAnswer();
    }
}
