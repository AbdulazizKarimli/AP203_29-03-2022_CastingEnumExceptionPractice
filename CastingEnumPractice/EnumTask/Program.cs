using System;

namespace EnumTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Exchange(Currency.Eur, 1));
        }

        public static double Exchange(Enum e, double azn)
        {
            if(e is Currency)
            {
                switch (e)
                {
                    case Currency.Usd:
                        return azn * 0.59;
                    case Currency.Eur:
                        return azn * 0.53;
                    case Currency.Try:
                        return azn * 8.71;
                    default:
                        return -1;
                }
            }

            return -1;
        }
    }
}
