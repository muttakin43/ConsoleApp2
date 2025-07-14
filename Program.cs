using System;


namespace ConsoleApp1
    {
        class Program
        {


            static void Main(string[] args)
            {
            int x;
            int y;
            double result;
            try
            {
                Console.Write("Enter first number: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;
                Console.WriteLine("Result: " + result);
            } 
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers please!");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("you can't divide by zero IDIOT!");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting");
            }
           
            Console.ReadLine();

        }
        }
    }


