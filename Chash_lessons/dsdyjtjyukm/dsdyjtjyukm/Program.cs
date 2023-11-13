//name: skylar
//Class:comp sci 20s
//description: determinds what number is the biggest 


using System.ComponentModel;
using System.ComponentModel.Design;

namespace beans
{
    public class hello
    {
        public static void Main()
        {
            Console.WriteLine("enter first number");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter second number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter third number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num > num1 && num > num2)
            {
                Console.WriteLine("the first {0} is the biggest",num );

            }
            else if (num1 > num && num1 > num2)
            {
                Console.WriteLine("the second is the biggest");
            }
            else if (num2 > num && num2 > num1)
            {
                Console.WriteLine("the third is the biggest");
            }
           
        
        
        
        
        
        
        }   
             


    }



 }




    



    
















