/* name:skylar
 * cklass: comp sci 20s
 * description functions 2*/
namespace beans
{
    public class hello
    {
        // when writing the functions, if the veriables does not have 
        //an inital value like string word, its manditory
        // if the variable has an intial value like bool showstars=ffalse
        //it is optional
        /*static void customMessage(string word, bool showstars = false)
        {
            //with optional imput,if the user sends an imput,the variable willuse the users imput
            //if the user does not send anything,the variable will use the inital(default)value
            if (showstars)
            {
                Console.WriteLine("******" + word + "******");
            }
            else
            {
                Console.WriteLine(word);
            }*/

        static void customMessage(string word, bool extracheese = false)
        {
            if (extracheese = true)
            {

                Console.WriteLine(" L + dont care ");

            }
            else 
            {
                Console.WriteLine("you dont want extra cheese");
            }

        }

        public static void Main()
        {


            /* Console.WriteLine("enter a word");
             string imput = Console.ReadLine();
             customMessage(imput);
             customMessage(imput, showstars:true);*/

            Console.WriteLine("what would you like to order");
            string imput = Console.ReadLine();
            Console.WriteLine("would you like extra cheese with that");
            while (1 == 1)
            {
                customMessage(imput);
                customMessage(imput, extracheese: false);
                customMessage(imput);
                customMessage(imput);
                customMessage(imput);
                customMessage(imput);
                customMessage(imput);
                customMessage(imput);

            }

        }    }    
}