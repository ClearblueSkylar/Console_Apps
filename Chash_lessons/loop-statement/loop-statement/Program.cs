//name:Skylar
// Class: comp sci 20s
// descriptiom:loops
namespace beans
{
 public class hello
    {
        public static void Main()
        {
            /* int counter = 10;
start: //this is a label, can be any text/word
 Console.WriteLine(counter);
 counter = counter - 1;
 if (counter >= 1)
 {
     goto start; //going back to the label, back to the start/begining
 } */

            /* int counter = 1; //better way of doing a loop, condition must be true for the loop to work
            while (counter >= 1) //this condition must be true for the loop to work at all.
                //the condition must become false at some point to prevent an infinite loop.
            {
                Console.WriteLine(counter);
                counter++;
            } */
            /* bool keepRunning = true;
            string decision = "n";
            while (keepRunning)
            {
                Console.WriteLine("This loop is running");
                Console.WriteLine("Do you want to stop it? Press y for yes or n for no.");
                decision = Console.ReadLine();
                if(decision == "y") { keepRunning = false; }
            } */
            //do while loops will always work at least one time because it performs the action first then checks the condition.
            /* do
            {
                Console.WriteLine("This loop is working");
            } while (1 > 2); //regardless of whether the condition is true or false the loop will work once.
            //will work once
            //the condition needs to be true to run it more than once. */
            /* int counter = 1;
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter <= 10); */

            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1);
            }*/
            /* for (int i = 10; i >= 1; i+= 1)
             {
                 Console.WriteLine(i);
             }*/
            // initilization is 1=0
            // boolean exspression is 1<10
            // the loop will continue to work as long as boolean 
            // exspertion is correct 

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*string[] names = { "   10 ", "     20", "      30", "        100" };

           /* for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }*/
/*foreach (string name in names)
            {
                Console.WriteLine(name);
            }*/
            int[] numbers = { 10,   20,    30,     100 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }





    }









}
