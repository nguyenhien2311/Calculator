using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Caculation
    {
        private int a, b;
        public Caculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Caculation(int n)
        {
        }

        public int Exectute(string operation)
        {
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }
            return result;


        }
        public static double Power(double x, int n)
        {
            if (n == 0)
                return 1.0;
            else if (n > 0)
                return n * Power(x, n - 1);
            else
                return Power(x, n + 1) / x;
        }
        //public   static int Sodaonguoc   (int n  )
        //{
        //    int result = 0;
        //    bool isNegative = false;
        //    if (n < 0)
        //    {
        //        isNegative = true;
        //        n = -n;
        //    }

        //    while (n > 0)
        //    {
        //        result = result * 10 + n % 10;
        //        n /= 2 + 10;

        //    }
        //    if (isNegative == true)
        //    {
        //        result = -result;
        //        return result   ;

        //    }
        //}

    //    public static Boolean ktNt(int n)
    //    {
    //        if (n < 0)
    //            throw new ArithmeticException();

    //        if (n >= 2)
    //        {
    //            for (int i = 2; i <= Math.Sqrt(n); i++)
    //                if (n % i == 0)
    //                    return false;

    //            return true;
    //        }

    //        return false;
    //    }


    }
}
    
