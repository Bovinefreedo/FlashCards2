using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.frameworks
{
    public interface IQuestion
    {
        public List<string> displayQuestion();
        public bool submitAnswer(List<bool> answers);
        public bool wasCorrect();
    }
}
