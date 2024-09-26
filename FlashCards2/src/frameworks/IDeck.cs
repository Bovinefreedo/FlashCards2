using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.frameworks
{
    public interface IDeck
    {
        public IDisplayQ nextQuestion();
        public void submitAnswer(bool[] answer);
        public IDisplayQ previousQuestion();
    }
}
