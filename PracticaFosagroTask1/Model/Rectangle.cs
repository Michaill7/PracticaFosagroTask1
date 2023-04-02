using PracticaFosagroTask1.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFosagroTask1.Model
{
    internal class Rectangle : PatternDetail
    {
        public override double V { get; set; }
        public double A;
        public double B;
        public double C;

        public Rectangle(double A, double B, double C, double V)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.V = V;
        }
    }
}
