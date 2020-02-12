using System;

namespace MentorMateFinishedTask
{
    public class LastRow : IDraw
    {
        public BackGroundSymbol backGround = new BackGroundSymbol();

        public LightBlueSymbol whiteBlue = new LightBlueSymbol();

        public DarkBlueSymbol darkBlue = new DarkBlueSymbol();

        public void Draw(int size)
        {
            for (int t = 0; t < 2; t++)
            {
                for (int d = 0; d < size; d++)
                {
                    Console.Write(darkBlue);
                }
                for (int k = 0; k < 2; k++)
                {
                    for (int b = 0; b < size; b++)
                    {
                        Console.Write(backGround);
                    }
                    for (int w = 0; w < size; w++)
                    {
                        Console.Write(whiteBlue);
                    }
                }
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
