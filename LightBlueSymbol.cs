using System;

namespace MentorMateFinishedTask
{
    public class LightBlueSymbol : ISymbol
    {
        public char symbol => '*';

        public char Colorized()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            var result = this.symbol;

            return result;
        }
        public override string ToString()
        {
            return $"{Colorized()}";
        }
    }
}
