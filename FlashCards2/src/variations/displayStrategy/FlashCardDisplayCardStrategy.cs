using FlashCards2.src.frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards2.src.variations.displayStrategy
{
    public class FlashCardDisplayCardStrategyStrategy : IDisplayStrategy
    {
        public void displayAnwser(IDisplayQ question)
        {
            Console.WriteLine(question.getQuestion());
        }

        public void displayQuestion(IDisplayQ question)
        {
            foreach (IAnswer anwser in question.getAnswers())
            {
                Console.WriteLine($"{anwser}");
            }
        }
    }
}
