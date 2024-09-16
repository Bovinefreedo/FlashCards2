using FlashCards2.src.frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.implimentation
{
    public class AnwserStub : IAnwser
    {
        private string _anwser;
        private bool _correct;
        public AnwserStub(string anwser, bool correct) {
            _anwser = anwser;
            _correct = correct;
        }
        public bool checkAnwser(bool anwser)
        {
            return _correct == anwser;
        }

        public string getAnwser()
        {
            return _anwser;
        }
    }
}
