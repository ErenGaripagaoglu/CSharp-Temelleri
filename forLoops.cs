using System;

namespace forLoops
{
    public static class forLoops
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i<10; i++)
            {
                //1st column states the variable that is going to be used in the loop
                //2nd column is the condition
                //3rd is the modification on the loop variable thats going to be done after each step
                Console.WriteLine(i);
            }
        }
    }
}