using System;

namespace MentorMateFinishedTask
{
    public class TopBody : IDraw
    {
        public BackGroundSymbol backGround = new BackGroundSymbol();

        public LightBlueSymbol whiteBlue = new LightBlueSymbol();

        public DarkBlueSymbol darkBlue = new DarkBlueSymbol();

        public void Draw(int size)
        {
            var midCounter = size - 2;
            var backCounter = 1;
            var symbCounter = 0;
            var darkCounter = 0;


            while (midCounter > 0)
            {
                for (int t = 0; t < 2; t++)
                {
                    while (symbCounter < size * 10)
                    {
                        for (int b = 0; b < size - backCounter; b++)
                        {
                            Console.Write(backGround);
                            symbCounter++;
                        }
                        for (int d = 0; d < 2 + darkCounter; d++)
                        {
                            Console.Write(darkBlue);
                            symbCounter++;
                        }
                        for (int w = 0; w < size; w++)
                        {
                            Console.Write(whiteBlue);
                            symbCounter++;
                        }
                        for (int b = 0; b < midCounter; b++)
                        {
                            Console.Write(backGround);
                            symbCounter++;
                        }
                        for (int d = 0; d < 2 + darkCounter; d++)
                        {
                            Console.Write(darkBlue);
                            symbCounter++;
                        }
                        for (int w = 0; w < size; w++)
                        {
                            Console.Write(whiteBlue);
                            symbCounter++;
                        }
                        for (int b = 0; b < size - backCounter; b++)
                        {
                            Console.Write(backGround);
                            symbCounter++;
                        }
                    }
                }
                symbCounter = 0;

                midCounter -= 2;
                darkCounter += 2;
                Console.WriteLine();

                backCounter++;
            }
        }
    }
}

