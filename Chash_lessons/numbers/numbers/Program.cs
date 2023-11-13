/*name:Skylar
 * class:comp sci 20s
 * Description:numbers*/
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace beans
{
    public class hello
    {
        
        public static void Main()
        {
            
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("the odd numbers between " + num + " and " + num2 + " are: ");
            int counter = num;

           

             beams:

                if (counter % 2  == 1)
                {
                    Console.WriteLine(counter);
                }
            counter++;


                if (counter <= num2)
                {
                    goto beams;

                }
            
            

        }
    }
}