using System;
namespace beans
{
    public class yourmom
    {
  // to declare a fuction 
  // data_type function_name (imput_data_type variable_name)
       static int sum(int num1, int num2) {
            return (num1 + num2);
        }




        public static void Main()
        {
            Console.WriteLine("enter a number");
            int num1 = Convert.ToInt32((string)Console.ReadLine());


        }
    
    
    
    
     static string bugerorder(string order, bool extracheese = false)
        {
            if (extracheese)
            {
                return order + "with extracheese";
            }
        
        else
            {
                return order + "without extra cheese";
            }
        
        }
    
    
    
    }
}
