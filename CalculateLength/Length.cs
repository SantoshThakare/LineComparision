using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLength
{
    public class Length
    {
        public void len()
        {
            int a1, a2, b1, b2;
            double ans;

            Console.WriteLine("Enter length point number (a1, b1)=");
            a1 = Convert.ToInt32(Console.ReadLine());
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length point number (a2, b2)=");
            a2 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            ans = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            Console.WriteLine(" The length is : " + ans);
        }
    }
}
