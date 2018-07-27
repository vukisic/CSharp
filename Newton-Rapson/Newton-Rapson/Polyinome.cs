using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton_Rapson
{
    public class Polynome
    {
        private int degree;
        private List<double> coef;

        public Polynome()
        {
            this.degree = 0;
            this.coef = new List<double>();
        }

        public Polynome(List<double> coef, int degree)
        {
            this.degree = degree;
            this.coef = new List<double>(coef);
        }

        public double GetValue(double a)
        {
            double s;
            s = coef[degree - 1];
            for (int i = degree - 2; i >= 0; --i)
            {
                s = s * a + coef[i];
            }
            return s;
        }
    }
}
