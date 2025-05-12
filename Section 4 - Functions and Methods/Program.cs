using System.Numerics;

namespace Section_4___Functions_and_Methods
{
    internal class Program
    {
        //Field or Instance Variable - Sometimes called Global Variable, It is a variable that exist outside of a method
        static decimal total;
        static int firstInput, secondInput;
        static char operation;

        // Main Method - Entry point of a program
        static void Main(string[] args)
        {

            GetUserInputs(out firstInput, out secondInput, out operation);

            switch (operation)
            {
                case '+':
                    Add(firstInput, secondInput);
                    break;
                case '-':
                    Subtract(firstInput, secondInput);
                    break;
                case '*':
                    Multiply(firstInput, secondInput);
                    break;
                case '/':
                    Divide(firstInput, secondInput);
                    break;
                default:
                    Console.WriteLine("Please enter a proper operation(+,-,*,/)");
                    break;

            }

            Console.WriteLine("Total:" + total);
            Console.ReadKey();
        }
        //static methods - methods that doesn't need and object to be called but only inside a class where it is created

        // void method with 'out' keyword
        //out - is an argument keyword that is used to pass arguments to methods by reference. Meaning, it modifies the data of the original source.
        static void GetUserInputs(out int firstInput, out int secondInput, out char operation){
            Console.WriteLine("Please enter 1st num:");
            firstInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Operation(+,-,*,/):");
            operation = char.Parse(Console.ReadLine());

            Console.WriteLine("Please enter 2nd num:");
            secondInput = int.Parse(Console.ReadLine());
        }

        static decimal Add(int firstNum, int secondNum)
        {
            total = firstNum + secondNum;
            return total;
        }
        static decimal Subtract(int firstNum, int secondNum)
        {
            total = firstNum - secondNum;
            return total;
        }
        static decimal Multiply(int firstNum, int secondNum)
        {
            total = firstNum * secondNum;
            return total;
        }
        static decimal Divide(int firstNum, int secondNum)
        {
            total = firstNum / secondNum;
            return total;
        }
    }
}
