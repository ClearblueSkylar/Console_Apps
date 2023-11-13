/*name:skylar
 * class:comp sci 20s 
 * description:hourly wage*/
using System.Diagnostics.CodeAnalysis;

namespace beans
{
    public class hello
    {
        public static void Main() {
            Console.WriteLine("enter how many hours you have worked");
           double hours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("how much do you get payed");      
            double wage = Convert.ToDouble(Console.ReadLine());
            double otHours = 0;
            double otPay = 0;
           if ( hours > 40)
            {
                otHours = hours - 40;
                otPay = otHours * 1.5 * wage; 
            }
            
            double raguler = 40 * wage;
           double sum = raguler * otPay;
            Console.WriteLine(raguler);
            Console.WriteLine(otPay);
            Console.WriteLine(sum);
            /* if (num <= 40)
            {
               

                Console.WriteLine("your regular pay is " + num3);
               
                Console.WriteLine("No overtime pay");
               
                Console.WriteLine("your total pay is " + num3);
            }
            else 
            {
               
                
               double num4 =  (num - 40);
                double num5 = (num4 * num2 * 1.5);
                Console.WriteLine("regular pay is " + num3);
                Console.WriteLine("your overtime pay is " + num5);
                double num6 = (num5 + num3);
                Console.WriteLine(" your total pay is " + num6);
            }
             */


        }
    }
}
