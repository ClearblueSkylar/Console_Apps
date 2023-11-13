/* name: skylar
 * Grade:10
 * Discription : this code deals with statements which are switch statement*/


using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace beans
{
    public class Hello
    {
        public static void Main()
        {//Console.WriteLine("Enter a number between one and twelve");
           
//int num = Convert.ToInt32(Console.ReadLine());
            /* if (num == 1)
             {

                 Console.WriteLine("January");
             }
             else if (num == 2)
             { 
                 Console.WriteLine("febuary");
             }
             else if ( num == 3) 
             {
                 Console.Write("march");
                     }
             else if ( num == 4)
             {
                 Console.WriteLine("april");
             }
              else if  (num == 5)
             {
                 Console.WriteLine("may");
             }   
            else if( num == 6)
             {
                 Console.WriteLine("june");
             }
              else if  (num == 7)
             {
                 Console.WriteLine("july");
             }*/
            // switch helps us compare one variable to multiple
            // other cases
            //here the variables month is compared to the numbers 
            // from 1-12
            /*switch (num)
                      {
                    case 1:// compares month to 1, if equal executes the print statement 
                              Console.WriteLine("january");
                              break;// break is needed
                    case 2:
                              Console.WriteLine("febuary");
                              break;

                    case 3:
                              Console.WriteLine("march");
                              break;
                    case 4:
                              Console.WriteLine("april");
                              break;
                    case 5:
                              Console.WriteLine("may");
                              break;
                    case 6:
                              Console.WriteLine("june");
                              break;
                    case 7:
                              Console.WriteLine("july");
                              break;   


                    case 8:
                              Console.WriteLine("aguest");
                              break;
                              case 9:
                              Console.WriteLine("september");
                              break;   
                              case 10:
                              Console.WriteLine("october");
                              break;
                              case 11:
                              Console.WriteLine("november");
                              break;
                              case 12:
                              Console.WriteLine("december");
                              break;
                          default:// only considered if all the above cases are false 
                              Console.WriteLine("invalid number");
                              break;
                      }*/

            Console.WriteLine("enter your name to learn your score");
            String beans = Console.ReadLine();
            
            switch (beans.ToLower())
            {
                case "greg":
                    Console.WriteLine("85%");
                        break;
                case "magnes":
                    Console.WriteLine("88%");
                    break;
                case "mann":
                    Console.WriteLine("89%");
                    break;
                case "lochlan":
                    Console.WriteLine("90%");
                    break;
                    default: 
                    Console.WriteLine("not in my class");
                        break;
            }
        
        
        
        
        
        
        
        
        
        
        
        
        }








    }

















}