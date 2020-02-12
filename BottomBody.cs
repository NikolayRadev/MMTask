using System;

namespace MentorMateFinishedTask
{
    public class BottomBody : IDraw
    {
        public BackGroundSymbol backGround = new BackGroundSymbol();

        public DarkBlueSymbol darkBlue = new DarkBlueSymbol();

        public LightBlueSymbol whiteBlue = new LightBlueSymbol();

        public void Draw(int size)
        {
            var backCounter = (size - 1) / 2;
            var betweenCounter = 1;
            var rightCounter = 1;

            while (backCounter > 0)
            {
                for (int t = 0; t < 2; t++)
                {
                    for (int b = 0; b < backCounter; b++)
                    {
                        Console.Write(backGround);
                    }
                    for (int d = 0; d < size; d++)
                    {
                        Console.Write(darkBlue);
                    }
                    for (int b = 0; b < betweenCounter; b++)
                    {
                        Console.Write(backGround);
                    }
                    for (int w = 0; w < size; w++)
                    {
                        Console.Write(whiteBlue);
                    }
                    for (int d = 0; d < size - rightCounter; d++)
                    {
                        Console.Write(darkBlue);
                    }

                    for (int b = 0; b < betweenCounter; b++)
                    {
                        Console.Write(backGround);
                    }
                    for (int w = 0; w < size; w++)
                    {
                        Console.Write(whiteBlue);
                    }
                    for (int i = 0; i < backCounter; i++)
                    {
                        Console.Write(backGround);
                    }
                }
                Console.WriteLine();

                backCounter--;
                betweenCounter += 2;
                rightCounter += 2;
            }
        }
    }
}
