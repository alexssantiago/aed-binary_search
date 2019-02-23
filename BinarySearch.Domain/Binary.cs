using System;

namespace BinarySearch.Domain
{
    public class Binary
    {
        public Binary() { }

        public Binary(int[] values)
        {
            Array.Sort(values);
        }

        public int Search(int[] values, int v, int first, int last)
        {
            int Medium = (first + last) / 2;

            if (first > last)
                return -1;
            else if (values[Medium] == v)
                return Medium;
            else if (values[Medium] < v)
                return Search(values, v, (Medium + 1), last);
            else
                return Search(values, v, first, (Medium - 1));
        }

    }
}
