using System;

namespace MentorMateFinishedTask
{
    public class FirstRow : IDraw
        {
            public BackGroundSymbol backGround = new BackGroundSymbol();

            public LightBlueSymbol whiteBlue = new LightBlueSymbol();
            public void Draw(int size)
            {
                Console.WriteLine();
                for (int t = 0; t < 2; t++)
                {
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write(backGround);
                    }
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write(whiteBlue);
                    }
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write(backGround);
                    }
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write(whiteBlue);
                    }
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write(backGround);
                    }
                }

                Console.WriteLine();
            }
        }
    }
