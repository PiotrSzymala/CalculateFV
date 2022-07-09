using System;
using System.Collections.Generic;
using System.Text;

namespace FvKalk
{
     static class MethodsToMenu
    {
        internal static void FV()
        {
            Console.SetCursorPosition(2, 1);

            Console.WriteLine("Enter the value of pv: ");
            Console.SetCursorPosition(26, 1);
            double pv = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.SetCursorPosition(2, 1);

            Console.WriteLine("Enter the value of r: ");
            Console.SetCursorPosition(26, 1);
            double r = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.SetCursorPosition(2, 1);

            Console.WriteLine("Enter the value of n: ");
            Console.SetCursorPosition(26, 1);
            double n = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.SetCursorPosition(2, 1);

            Console.WriteLine($"Value of FV =  {Math.Round(pv * (1 + ((r / 100) * n)), 2):C}");
            Console.ReadKey();
        }
        internal static void PV()
        {
            Console.SetCursorPosition(2, 1);

            Console.WriteLine("Enter the value of fv: ");
            Console.SetCursorPosition(26, 1);
            double fv = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.SetCursorPosition(2, 1);

            Console.WriteLine("Enter the value of r: ");
            Console.SetCursorPosition(26, 1);
            double r = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.SetCursorPosition(2, 1);

            Console.WriteLine("Enter the value of n: ");
            Console.SetCursorPosition(26, 1);
            double n = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.SetCursorPosition(2, 1);

            Console.WriteLine($"Value of PV =  {Math.Round(fv / (1 + ((r / 100) * n)),2):C}");
            Console.ReadKey();
        }

        public static void FrictionOperations()
        {
            Console.SetCursorPosition(2, 1);

            Console.WriteLine("Enter the value of 1st numerator: ");
            Console.SetCursorPosition(38, 1);
            int numeartor = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.SetCursorPosition(2, 1);

            Console.WriteLine("Enter the value of 1st denumerator: ");
            Console.SetCursorPosition(38, 1);
            int denumerator = int.Parse(Console.ReadLine());
            Console.Clear();

            Friction f1 = new Friction(numeartor, denumerator);

            Console.SetCursorPosition(2, 1);

            Console.WriteLine("Enter the value of 2nd numerator: ");
            Console.SetCursorPosition(38, 1);
            numeartor = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.SetCursorPosition(2, 1);

            Console.WriteLine("Enter the value of 2nd denumerator: ");
            Console.SetCursorPosition(38, 1);
            denumerator = int.Parse(Console.ReadLine());
            Console.Clear();

            Friction f2 = new Friction(numeartor, denumerator);

            Console.SetCursorPosition(2, 1);
            Console.WriteLine($"f1 + f2 =  {f1 + f2}");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine($"f1 - f2 =  {f1 - f2}");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine($"f1 * f2 =  {f1 * f2}");
            Console.ReadKey();

        }
        public static void SumComplex()
        {
            Console.SetCursorPosition(2, 1);

            Console.WriteLine("Enter the value of 1st rez part: ");
            Console.SetCursorPosition(36, 1);
            int rez = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.SetCursorPosition(2, 1);

            Console.WriteLine("Enter the value of 1st im part: ");
            Console.SetCursorPosition(36, 1);
            int im = int.Parse(Console.ReadLine());
            Console.Clear();

            ComplexNumber c1 = new ComplexNumber(rez, im);

            Console.SetCursorPosition(2, 1);

            Console.WriteLine("Enter the value of 2nd rez part: ");
            Console.SetCursorPosition(36, 1);
            rez = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.SetCursorPosition(2, 1);

            Console.WriteLine("Enter the value of 2nd im part: ");
            Console.SetCursorPosition(36, 1);
            im = int.Parse(Console.ReadLine());
            Console.Clear();

            ComplexNumber c2 = new ComplexNumber(rez, im);

            Console.SetCursorPosition(2, 1);
            Console.WriteLine($"c1 + c2 =  {c1 + c2}");

            Console.ReadKey();
        }
    }
}
