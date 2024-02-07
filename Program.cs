using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesantTestOne
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Program prm = new Program();
            //prm.WhileLoop();
            //prm.DoWhile();
            //prm.FindSqRootNumbers();
            //prm.SumOfEvenNum();
            // prm.FindEvenOddNumbers();
            // prm.FindFactorialOfNumber();
            //prm.ReturnValueFromSwitch();
            //prm.FindFibonacciSeries();
            //prm.BreakExitFromLop();
            prm.FindMaxNum();
        }

        public void WhileLoop()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("The i value is : {0}", i);
                i++;
            }
        }

        public void DoWhile()
        {
            int i = 1;
            do
            {
                Console.WriteLine("The Do while loop i value is : {0}", i);
                i++;
            } while (i <= 5);
        }

        private void FindSqRootNumbers()
        {
            for (int counter = 1; counter <= 4; counter++)
            {
                Console.WriteLine(counter * counter);
                counter++;
            }
        }

        private void SumOfEvenNum()
        {
            int sum = 0;
            Console.Write("Enter value a Number:");
            int Number = Convert.ToInt32(Console.ReadLine());
            //start with 2
            //2+2 = 4
            //4+2 = 6
            for (int i = 2; i <= Number; i += 2)
            {
                sum += i;
            }
            Console.Write($"Sum of even numbers from 1 to {Number} is : {sum}");
            Console.ReadLine();
        }

        private void FindEvenOddNumbers()
        {
            Console.Write("Enter a Number:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Negative Number!");
            }
            else if (n == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Positive Number!");
            }
            Console.ReadLine();
        }

        private void FindFactorialOfNumber()
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.Write($"Factorial of {number}  is: {factorial}");

            Console.ReadLine();
        }

        private void ReturnValueFromSwitch()
        {
            Console.Write("Enter some value: ");
            int n = int.Parse(Console.ReadLine());
            int value;
            switch (n)
            {
                case 1:
                    value = 10;
                    break;
                case 2:
                    value = 20;
                    break;
                case 3:
                    value = 30;
                    break;
                default:
                    value = 100;
                    break;
            }

            Console.Write($"The entered value is {n}, which holds value:{value}");
            Console.ReadLine();
        }

        private void FindFibonacciSeries()
        {
            int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            Console.Write("Enter the number of elements to Print : ");
            numberOfElements = int.Parse(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                //First print first and second number
                Console.Write(firstNumber + " " + SecondNumber + " ");
                //Starts the loop from 2 because 0 and 1 are already printed
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }

            Console.ReadKey();
        }

        private void BreakExitFromLop()
        {
            string greeting = "Good Morning!";

            for (int i = 0; i < greeting.Length; i++)
            {
                if (greeting[i] == ' ')
                {
                    break;
                }
                Console.Write(greeting[i]);
            }
        }

        public void FindMaxNum()
        {
            Console.Write("Eneter number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Eneter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Eneter number 3: ");
            int num3 = int.Parse(Console.ReadLine());
            int maxValue = 0;
            if (num2 < num1 && num1 > num3)
            {
                maxValue = num1;
            }

            else if (num1 < num2 && num2 > num3)
            {
                maxValue = num2;
            }

            else
            {
                maxValue = num3;
            }
            Console.WriteLine($"The maximum vlaue is : {maxValue}");
            Console.ReadLine();
        }
    }
}
