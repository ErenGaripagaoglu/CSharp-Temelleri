using System;

namespace whileLoop
{
    public static class whileLoop
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            while (counter <= 10) //while, checks the condition and if its true. If condition is met, then it runs the code inside while condition is still met.
            {
                Console.WriteLine(counter);
                counter++;
            }
        }
    }
}