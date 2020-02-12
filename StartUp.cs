using System;

namespace MentorMateFinishedTask
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write Odd number:");

                var MentorMateLogo = new Logo(Console.ReadLine());

                MentorMateLogo.DrawLogo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
