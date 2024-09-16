using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.frameworks
{
    public interface IAnwser
    {
        public bool checkAnwser(bool anwser);
        public string getAnwser();
    }
}
