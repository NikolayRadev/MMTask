using System;

namespace MentorMateFinishedTask
{
    public class BackGroundSymbol : ISymbol
    {
        public char symbol => '-';

        public char Colorized()
        {
            Console.ForegroundColor = ConsoleColor.White;

            var result = symbol;

            return result;
        }

        public override string ToString()
        {
            return $"{Colorized()}";
        }
    }
}
