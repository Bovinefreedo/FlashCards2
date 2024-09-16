using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.frameworks
{
    public interface IQuestion
    {
        public string[] displayQuestion();
        public bool submitAnwser(bool[] anwsers);
        public bool wasCorrect();
    }
}
