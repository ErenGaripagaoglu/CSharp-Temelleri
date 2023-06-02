using System;

namespace variableTypes
{
    public static class variableTypes
    {
        public static void Main(string[] args)
        {
            //We need to identify variable types before using them in an action.

            int variable_Name; //We can create a variable like this
            
            int variable_Value = 5; //We can create and assign a value to a variable like this

            int variable_Type;
            variable_Type = 1; //We can assign a value seperately after creating the variable

            //////////////////////////////////////////////

            int number = 1; //This is a integer
            Console.WriteLine(number);

            float decimals = 1.2f; //This is a float
            Console.WriteLine(decimals);

            double numberWithDecimal = 1.45; //This is a double 
            Console.WriteLine(numberWithDecimal);

            string textVar = "This is a string!"; //This is a string
            Console.WriteLine(textVar);
            
            bool Boolean = false; //This is a boolean
            Console.WriteLine(Boolean);            
        }
    }
}