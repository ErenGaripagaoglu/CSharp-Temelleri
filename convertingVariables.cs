namespace convertingVariables
{
    public static class convertingVariables
    {
        public static void Main(string[] args)
        {
            //Integer to Double
            int number = 3;
            Console.WriteLine(number + " is " + number.GetType().ToString());
            double floatNumber = Convert.ToDouble(number);
            Console.WriteLine(floatNumber + " is " + floatNumber.GetType().ToString());


            //Double to Integer
            double doubleNumber = 5.27;
            Console.WriteLine(doubleNumber + " is " + doubleNumber.GetType().ToString());
            int number1 = Convert.ToInt32(doubleNumber);
            Console.WriteLine(number1 + " is " + number1.GetType().ToString());

            //String to Integer
            string text1 = "4";
            Console.WriteLine(text1 + " is " + text1.GetType().ToString());
            int number2 = Convert.ToInt32(text1);
            Console.WriteLine(number2 + " is " + number2.GetType().ToString());

            //Integer to String
            int number3 = 6;
            Console.WriteLine(number3 + " is " + number3.GetType().ToString());
            string text2 = number3.ToString();
            Console.WriteLine(text2 + " is " + text2.GetType().ToString());
        }
    }
}