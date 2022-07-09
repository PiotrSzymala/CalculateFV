using System;
using System.Collections.Generic;
using System.Text;

namespace FvKalk
{
    class ComplexNumber
    {
        int _rez;
        int _im;
        public ComplexNumber(int rez, int im)
        {
            _rez = rez;
            _im = im;
        }
        public override string ToString()
        {
            return $"{_rez}+{_im}i";
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a._rez + b._rez, a._im + b._im);
        }
    }
}
