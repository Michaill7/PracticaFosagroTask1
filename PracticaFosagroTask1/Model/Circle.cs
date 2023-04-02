using PracticaFosagroTask1.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFosagroTask1.Model
{
    internal class Circle : PatternDetail
    {
        public override double V { get; set; }
        private double R;
        private double H;
        public Circle(double R, double H)
        {
            this.R = R;
            this.H = H;
        }
    }
}
