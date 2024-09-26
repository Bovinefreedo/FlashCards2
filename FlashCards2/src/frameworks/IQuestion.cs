using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.frameworks
{
    public interface IQuestion
    {
        public List<string> showAnswered();
        public List<string> showUnanswered();
        public List<string> displayQuestion();
        public void submitAnswer(List<bool> answers);
        public bool wasCorrect();
    }
}
