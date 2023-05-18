using System;

namespace mathOperators {

	public static class mathOperators {
        
        public static void Main(string[] args) {
            int a, b; //We need to identify variable types before using them in an action.

            a = 9;
            b = 4;

            int sum;
            int sub;
            int mult;
            double div;

            sum = a + b;
            Console.WriteLine(sum);

            sub = a - b;
            Console.WriteLine(sub);

            mult = a * b;
            Console.WriteLine(mult);

            div = a / b;
            Console.WriteLine(div);
        }
	}
}