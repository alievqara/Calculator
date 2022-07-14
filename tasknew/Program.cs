using System;

namespace tasknew
{
    public class Program
    {


        static void Main()
        {

            int FirstNumber;
            int SecondNumber;

            FirstNumber = 5;
            SecondNumber = 2;

            Addition addition = new Addition();


            Console.WriteLine($"Addition: First Number:{FirstNumber},Second Number:{SecondNumber}, Result:{addition.Operate(FirstNumber,SecondNumber)}");


            Substraction substraction = new Substraction();

            Console.WriteLine($"Substraction: First Number:{FirstNumber},Second Number:{SecondNumber}, Result:{substraction.Operate(FirstNumber, SecondNumber)}");


            Multiplication multiplication = new Multiplication();

            Console.WriteLine($"Multiplication: First Number:{FirstNumber},Second Number:{SecondNumber}, Result:{multiplication.Operate(FirstNumber, SecondNumber)}");


            Division division = new Division();


            Console.WriteLine($"Division: First Number:{FirstNumber},Second Number:{SecondNumber}, Result:{division.Operate(FirstNumber, SecondNumber)}");



        }
    }
}
