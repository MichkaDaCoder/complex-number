using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex_number
{
    /// <summary>
    /// Complex.cs
    /// Author: MichkaDaCoder
    /// Date: 06.11.2022
    /// </summary>
    public class Complex
    {
        /// <summary>
        /// Real part
        /// </summary>
        public double Re { get; set; }

        /// <summary>
        /// Imaginary part
        /// </summary>
        public double Im { get; set; }


        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="Re"></param>
        /// <param name="Im"></param>
        public Complex(double Re, double Im)
        {
            this.Re = Re;
            this.Im = Im;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Re);
            sb.Append(Im > 0 ? "+" + Im+"i" : Im + "i");
            return sb.ToString();
        }

        /// <summary>
        /// Return the sum of 2 complex numbers
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>Complex</returns>
        public Complex Sum(Complex c1, Complex c2)
        {
            return new Complex(c1.Re + c2.Re, c1.Im + c2.Im);
        }

        /// <summary>
        /// Return the sub of 2 complex numbers
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public Complex Sub(Complex c1, Complex c2)
        {
            return new Complex(c1.Re - c2.Re, c1.Im - c2.Im);
        }
    }
}
