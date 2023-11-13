/* name:skylar
 * class:comp sci 20s
 * description: this code deals with functions, mandatory and optional parameters*/
using System.Diagnostics.Tracing;

namespace beans
{ 
    public class hello
    {
        // void means empty return
        // a void does not reaturn anything
        /* static void CustomMesssage (string word )
         {
          Console.WriteLine ("******"+ word+"*******");
         }*/


        // this static taks num1 and num2 and returns there sum
        /* static  int sum (int num1, int num2)
         {
             return num1 + num2;
         }*/


        public static void Main()
        {

            /* Console.WriteLine("please enter a word");
             string imput = Console.ReadLine ();
       // we call functions by there names and() to it
       // if the functions take imput ,we put them in the brackets
             CustomMesssage(imput);
           // the functions executes every time we call it*/



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////          ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /* Console.WriteLine("enter the first number");
             int first = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("enter the second number");
              int second = Convert.ToInt32(Console.ReadLine());  
             // when a functio returns a value we need to store that value in a veriable to use it
              int results = sum(first, second);
                 Console.WriteLine(" the sum is " + results);*/

            /* static int product(int num1, int num2)
                {
                    return (num1 * num2);
                }
                Console.WriteLine("enter the first number");

            int first = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" entrer the second number");
             int second = Convert.ToInt32(Console.ReadLine());  

            int results = product(first, second);
                Console.WriteLine("the product is " + results);*/

           /* static String tolowerOrupper(String word, bool tolower)
            {


                if (tolower)
                {
                    return word.ToLower();
                }
                else
                {
                    return word.ToUpper();
                }
            }
                Console.WriteLine("enter a word");
                string input = Console.ReadLine();
                String ChangedWord = tolowerOrupper(input, false);
                Console.WriteLine(ChangedWord);*/




            

        }
    }

}
