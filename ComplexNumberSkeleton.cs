using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComplexNumberApplication
{
    class ComplexNumber
    {
        // instance variables
        private double re;
        private double im;

        // initialise a new complex number to zero
        public ComplexNumber()
        {
            this.re = 0.0;
            this.im = 0.0;
        }

        // initialise a new complex number to be equal to
        // specified complex number
        public ComplexNumber(ComplexNumber other)
        {
            this.re = other.GetRe();
            this.im = other.GetIm();
        }

        // initialise a new complex number to be equal to
        // specified values
        public ComplexNumber(double real, double imaginary)
        {
            // ** COMPLETE **
        }

        // return real part of complex number
        public double GetRe()
        {
            return this.re;
        }

        // return imaginary part of complex number
        public double GetIm()
        {
            return this.im;
        }

        // add specified complex number to current complex number
        public void Add(ComplexNumber other)
        {
            // ** COMPLETE ** -- Requires use of GetRe(), GetIm()

        }

        // subtract specified complex number from current complex number
        public void Subtract(ComplexNumber other)
        {
            // ** COMPLETE ** -- Requires use of GetRe(), GetIm()
        }

        // multiply current complex number by specified complex number
        public void Multiply(ComplexNumber other)
        {
            // save real part of original complex numner
            double x = this.re;

            // ** COMPLETE ** -- Requires use of GetRe(), GetIm()
        }

        // divide current complex number by specified complex number
        // Divisor must be <> 0
        public bool Divide(ComplexNumber other)
        {
            // save real part of original complex numner
            double x = this.re;

            double divisor = (other.GetRe() * other.GetRe()) +
                                (other.GetIm() * other.GetIm());

            // check if division is possible
            if (divisor != 0.0)
            {
                // ** COMPLETE ** -- Requires use of GetRe(), GetIm()
                return true;
            }
            else
                return false;
        }

        // return conjugate of current complex number
        public ComplexNumber Conjugate()
        {
            return new ComplexNumber(this.re, -this.im);
        }

        // return a string representing the current complex number
        public string ToString()
        {
            string sign = (this.im < 0 ? " - " : " + ");

            return this.re + sign + Math.Abs(this.im) + "i";
        }

    }  // end class
} // end namespace
