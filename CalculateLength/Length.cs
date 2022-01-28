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
            int a1, a2, b1, b2, c1, c2, d1, d2;
          
            Console.WriteLine("----Line 1 -----");
            Console.WriteLine("Enter the Co-ordinate (a1, b1)=");
            a1 = Convert.ToInt32(Console.ReadLine());
            b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Co-ordinate (a2, b2)=");
            a2 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----Line 2----- ");
            Console.WriteLine("Enter the Co-ordinate (c1, c2)=");
            c1 = Convert.ToInt32(Console.ReadLine());
            c2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Co-ordinate (d1, d2)=");
            d1 = Convert.ToInt32(Console.ReadLine());
            d2 = Convert.ToInt32(Console.ReadLine());

            double firstlinedistance = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            double secondlinedistance = Math.Sqrt(Math.Pow((c2 - c1), 2) + Math.Pow((d2 - d1), 2));

            if (firstlinedistance == secondlinedistance)
            {
                Console.WriteLine("Line 1 and Line 2 are equal");

            }
            if (firstlinedistance > secondlinedistance)
            {
                Console.WriteLine("Line 1 is greater than Line 2 ");

            }
            if (firstlinedistance < secondlinedistance)
            {
                Console.WriteLine("Line 1 is less than Line 2");
            }
            
        }
    }
}
