using System;
using System.Collections.Generic;

namespace MentorMateFinishedTask
{
    public class Logo
    {
        public FirstRow firstRow = new FirstRow();

        public TopBody topBody = new TopBody();

        public BottomBody bottomBody = new BottomBody();

        public LastRow lastRow = new LastRow();

        private int size;

        public int Size
        {
            get { return size; }
            set
            {
                if (value < 3)
                {
                    throw new ArgumentException();
                }
                else if (value > 10000)
                {
                    throw new ArgumentException();
                }
                else if (value % 2 == 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    size = value;
                }
            }
        }

        public Logo()
        {
        }

        public Logo(string input)
        {
            try
            {
                Size = int.Parse(input);
            }
            catch (Exception)
            {
                throw new ArgumentException("Invalid input.");
            }
        }

        public void DrawLogo()
        {
            IEnumerable<IDraw> allRows = new List<IDraw>
            {
                firstRow,
                topBody,
                bottomBody,
                lastRow
            };

            foreach (var row in allRows)
            {
                row.Draw(size);
            }
        }
    }
}
