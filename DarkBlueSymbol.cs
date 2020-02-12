using System;

namespace MentorMateFinishedTask
{
    public class DarkBlueSymbol : ISymbol
    {
        public char symbol => '*';

        public char Colorized()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            var result = symbol;

            return result;
        }
        public override string ToString()
        {
            return $"{Colorized()}";
        }
    }
}
