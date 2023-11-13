/*name:skylar
 * class: comp sci 20s 
 * description:addtill*/
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace beans
{
    public class hello
    {
        public static void Main()
        {
            Console.WriteLine("enter a number");
            int upperbound = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= upperbound; i++) {
                Console.WriteLine(i);
            
             sum = (sum + i);
            }

            Console.WriteLine("these numbers add up to " + sum);





        }

    }
}
