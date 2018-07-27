using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton_Rapson
{
    //For functins:
    //Entering coef's backwards from Poly[0 degree] to Poly[largest degree]

    class Program
    {
        public delegate double F_x(double x, int degP, List<double> listP); //Delegate = like pointer to function

        static void Main(string[] args)
        {
            int degP = 0;
            List<double> listP = new List<double>();
            Console.WriteLine("*** Polynomal function ***");
            Console.WriteLine("Degree:");
            degP = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter coef:");
            for (int i = 0; i < degP + 1; ++i)
            {
                Console.Write("Pol[{0}]=", i);
                double a = Convert.ToDouble(Console.ReadLine());
                listP.Add(a);
            }

            int degD = 0;
            List<double> listD = new List<double>();
            Console.WriteLine("*** Derivate function ***");
            Console.WriteLine("Degree:");
            degD = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter coef:");
            for (int i = 0; i < degD+ 1; ++i)
            {
                Console.Write("Pol[{0}]=", i);
                double a = Convert.ToDouble(Console.ReadLine());
                listD.Add(a);
            }

         
            Console.Write("Enter Starting Value:");
            double start = Double.Parse(Console.ReadLine());
            Console.Write("Enter a number of Decimal places for limit:");
            int limit = Int32.Parse(Console.ReadLine());

            Console.Clear();
            NewtonRapson(start,limit, new F_x(Poly), new F_x(FirstDerivate),degP,listP,degD,listD);
            Console.ReadLine();
        }

        static void NewtonRapson(double startvalue,int limit,F_x XPolynome,F_x XDerivate,int degP,List<double> listP,int degD,List<double>listD)
        {
            const int MaxIterations = 1000;
            double limited = (1 / Math.Pow(10,limit));
            Console.SetWindowSize(80, 30);

            double Xh=0.0, Xh1 = 0.0;
            string linestr = string.Empty;
            linestr = linestr.PadRight(72, '-');
            Console.WriteLine(linestr);
            Console.WriteLine("| {0,-15}| {1,-15} | {2,-15} | {3,-15} |       ", "Iteration", "x", "f(x)", "f'(x)");
            Console.WriteLine(linestr);
            Console.WriteLine("|     {0,-10} | {1,15:0.00000} | {2,15:0.00000} | {3,15:0.00000} |       ", 0, startvalue, XPolynome(startvalue, degP, listP), XDerivate(startvalue,degD, listD));

            Xh = startvalue;
            for(int i = 1; i < MaxIterations; ++i)
            {
                Xh1 = Xh - (XPolynome(Xh,degP,listP)/XDerivate(Xh,degD,listD));
               
                if (Math.Abs(Xh1 - Xh) <= limited)
                {
                    Console.WriteLine(linestr);
                    Console.WriteLine("Root = {0,15:0.00000}".PadRight(Console.WindowWidth), Xh);
                    break;
                }
                else
                {
                    Console.WriteLine("|     {0,-10} | {1,15:0.00000} | {2,15:0.00000} | {3,15:0.00000} |       ", i, Xh1, XPolynome(Xh1, degP, listP), XDerivate(Xh1, degD, listD));
                    Xh = Xh1;
                }
            }
        }


        static double Poly(double x,int degP,List<double>listP)
        {
            Polynome p1 = new Polynome(listP, degP + 1);
            return p1.GetValue(x);
        }

        static double FirstDerivate(double x, int degD, List<double> listD)
        {
            Polynome p1 = new Polynome(listD, degD + 1);
            return p1.GetValue(x);
        }

    }
}
