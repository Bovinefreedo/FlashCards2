using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.frameworks
{
    public interface IDisplayStrategy
    {
        public void displayQuestion(IDisplayQ question);
        public void displayAnwser(IDisplayQ question);
    }
}
