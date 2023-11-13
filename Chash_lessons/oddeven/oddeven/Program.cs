//name:skylar
//class: comp sci 20s
// description:odd numbers
namespace beans
{
    public class hello
    {
        public static void Main()
        {
            Console.WriteLine("enter a number ");
          int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());




            IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

            foreach  (int num in squares)
            {
                Console.WriteLine(num);
            }

        }
    }
}