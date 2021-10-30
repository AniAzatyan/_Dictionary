using System;

namespace _Dictionary
{
    public class _HashHelpers
    {
        public static bool _IsPrime(int candidate)
        {
            if ((candidate & 1) != 0)
            {
                int limit = (int)Math.Sqrt(candidate);
                for (int divisor = 3; divisor <= limit; divisor += 2)
                {
                    if ((candidate % divisor) == 0)
                        return false;
                }
                return true;
            }
            return (candidate == 2);
        }
        public static int _GetPrime(int number)
        {
            if (number < 2)
                return 2;

            int prime = number;
            bool found = false;

            while (!found)
            {
                prime++;

                if (_IsPrime(prime))
                    found = true;
            }
            return prime;
        }
        public static int _ExpandPrime(int oldSize)
        {
            int newSize = 2 * oldSize;

            if ((uint)newSize > 0x7FEFFFFD && 0x7FEFFFFD > oldSize)
            {
                return 0x7FEFFFFD;
            }

            return _GetPrime(newSize);
        }

    }
}
