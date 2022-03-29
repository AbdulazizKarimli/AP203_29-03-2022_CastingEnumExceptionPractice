using System;

namespace ExceptionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            try
            {
                human.Age = 0;
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
