using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComplexNumberApplication
{
    class ComplexProgram
    {
        private const string EXIT = "e";

        // Class method. Since no instances of the program class are usually created,
        // the method is used only by Main(). To declare a class method, use the
        // keyword static.
        public static ComplexNumber ReadComplex(string prompt)
        {
            Console.WriteLine(prompt);
            Console.Write("Real part => ");
            double r = double.Parse(Console.ReadLine());

            Console.Write("Imaginary => ");
            double i = double.Parse(Console.ReadLine());

            return new ComplexNumber(r, i);

        } // end ReadComplex

        static void Main()
        {

            ComplexNumber c1, c2;
            string op;

            // Read the first complex number
            c1 = ReadComplex("\nPlease enter the first complex number:");

            // Read in the operation required
            do
            {

                Console.Write("\nEnter arithmetic operation    + - * / e<xit> => ");
                op = Console.ReadLine().ToLower();

                if (op.Equals(EXIT))
                    break;

                else if (op.Equals("+"))
                {
                    c2 = ReadComplex("\nEnter second complex number:");
                    Console.Write("\nAdding " + c1.ToString() + " to " + c2.ToString() + " results in: ");
                    c1.Add(c2);
                    Console.Write(c1.ToString());
                }
                else if (op.Equals("-"))
                {
                    c2 = ReadComplex("\nEnter second complex number:");
                    Console.Write("\nSubtracting " + c2.ToString() + " from " + c1.ToString() + " results in: ");
                    c1.Subtract(c2);
                    Console.Write(c1.ToString());
                }
                else if (op.Equals("*"))
                {
                    c2 = ReadComplex("\nEnter second complex number:");
                    Console.Write("\nMultiplying " + c1.ToString() + " by " + c2.ToString() + " results in: ");
                    c1.Multiply(c2);
                    Console.Write(c1.ToString());
                }
                else if (op.Equals("/"))
                {
                    c2 = ReadComplex("\nEnter second complex number:");
                    if (c1.Divide(c2))
                    {
                        Console.Write("\nDividing " + c1.ToString() + " by " + c2.ToString() + " results in: ");
                        Console.Write(c1.ToString());
                    }
                    else
                        Console.WriteLine("\nUnable to divide " + c1.ToString() + " by " + c2.ToString() + ".");
                }


            } while (!op.Equals(EXIT)); // end do while

            Console.WriteLine("\nPress RETURN to exit program.");
            Console.ReadLine();
        } // end Main()
    } // end class
} // end namespace
