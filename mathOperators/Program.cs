using System;

namespace mathOperators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            string x = Console.ReadLine();
            decimal firstNum = Int32.Parse(x);
            Console.WriteLine("Enter another Number");
            string y = Console.ReadLine();
            decimal secondNum = Int32.Parse(y);


            decimal additionResults = firstNum + secondNum;
            decimal subtractionResults = firstNum - secondNum;
            decimal multiplicationResults = firstNum * secondNum;
            decimal divisionResults = firstNum / secondNum;
            decimal modulusResults = firstNum % secondNum;

            Console.WriteLine("The total of " + firstNum + " and " + secondNum + " is " + additionResults + "\n\n");
            Console.WriteLine("The total of " + firstNum + " minus " + secondNum + " is " + subtractionResults + "\n\n");
            Console.WriteLine("The total of " + firstNum + " multiplied by " + secondNum + " is " + multiplicationResults + "\n\n");
            Console.WriteLine("The total of " + firstNum + " divided by " + secondNum + " is " + divisionResults + "\n\n");
            Console.WriteLine("The modulus of " + firstNum + " and  " + secondNum + " is " + modulusResults + "\n\n");



        }
    }
}
