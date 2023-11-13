/* name :Skylar
 * class : comp sci 20s
 * description:tells the user there is or there is not a bomb in the sentence */
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace beans
{
    public class hello
    {
        public static void Main()
        {
            Console.WriteLine(" enter a sentence ");

            string word = (Console.ReadLine());

            string bomb = word.ToLower();


            if (bomb.Contains("bomb"))
            {
                Console.Write("THERES A BOMB!!!!!");
            }
            else
            {   
               Console.WriteLine("THERE IS NO BOMB!!!");
            }
        }   

    }





}