using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please enter your pin number");
            string pinNumber = Console.ReadLine();
            if (pinNumber.Length > 3 && pinNumber.Length < 9);
            bool isValid;
            int a;
            isValid = int.TryParse(pinNumber, out a);
            Console.WriteLine("Pin number is valid:" + isValid);

        }
    }
}
