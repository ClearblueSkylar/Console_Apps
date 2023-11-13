/*
 * name: mr soloman
 * class:comp sci 20s
 * Description: this code deals with loop statements
 */
namespace beans
{
    public class hello
    {
        public static void Main ()
        {
            /* int counter = 10;


              beginning:

             Console.WriteLine (counter);
             counter = counter - 1;  


             if (counter >= 1) { 

                 goto beginning;
            }
             while (counter <= 10)
             Console.WriteLine (counter);
             {
                 counter++;*/


            bool keeprunning = true;
            string decision = "n";
            while (keeprunning)
            {
                Console.WriteLine("this loop is runing ");
                Console.WriteLine("do you want to stop it press y or n ");
              decision = Console.ReadLine();
            if (decision == "y") { keeprunning = false;}
}
            }



        }


    }


    


