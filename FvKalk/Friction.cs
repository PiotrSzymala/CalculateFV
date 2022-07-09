using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace FvKalk
{
    class Friction
    {
        int numerator;
        int denumerator;

        public Friction(int numerator, int denumerator)
        {
            if (denumerator == 0)
            {
                throw new ArgumentException("Denumerator cannot equal 0!");
            }
            this.numerator = numerator;
            this.denumerator = denumerator;
            Reduce();
        }

        public override string ToString()
        {
            return $"{numerator}/{denumerator} ";
        }

        private int NWD(int a, int b)
        {
            a = Abs(a);
            b = Abs(b);

            if (b == 0) return a;
            else return NWD(b, a % b);
        }
        private void Reduce()
        {
            if (denumerator < 0)
            {
                numerator = -numerator;
                denumerator = -denumerator;
            }
            int divider = NWD(numerator, denumerator);
            numerator /= divider;
            denumerator /= divider;
        }

        public static Friction operator +(Friction f1, Friction f2)
        {
            return new Friction(f1.numerator * f2.denumerator + f2.numerator * f1.denumerator,
                f1.denumerator * f2.denumerator);
        }
        public static Friction operator -(Friction f1, Friction f2)
        {
            return new Friction(f1.numerator * f2.denumerator - f2.numerator * f1.denumerator,
                f1.denumerator * f2.denumerator);
        }
        public static Friction operator *(Friction f1, Friction f2)
        {
            return new Friction(f1.numerator * f2.numerator, f1.denumerator * f2.denumerator);
        }
        public static Friction operator *(Friction f1, int a)
        {
            return new Friction(f1.numerator * a, f1.denumerator);
        }
    }
}
