/*name:skylar
 * class: comp sci 20s 
 * description: gives number between 0-10*/ 
namespace beans
{
    public class hello
    {
        public static void Main()
        {
            Console.WriteLine("Give me a number between zero and ten");
            double num = Convert.ToDouble (Console.ReadLine());

            if (num >= 0 && num <= 10)
            {
                Console.WriteLine("the number " + num + " is between 0-10");
            }
            else
            {
                Console.WriteLine("the number is not between 0-10");
            }

        }

    }
} 
