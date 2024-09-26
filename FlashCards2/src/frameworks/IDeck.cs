using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.frameworks
{
    public interface IDeck
    {
        public List<string> nextQuestion();
        public void submitAnswer(bool[] answer);
        public List<string> previousQuestion();
    }
}
