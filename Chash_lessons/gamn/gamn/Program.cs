/* name skylar 
 * class comp sci 20s
 * description code*/

namespace beans
{
    public class hello
    {
        public static void Main()
        {
           // how to send a message to the user 
            Console.WriteLine("hello world");
            // how to take int or double input from the user
            int age = Convert.ToInt32(Console.ReadLine());
            double score = Convert.ToDouble(Console.ReadLine());
            //how to take a string as imput 
            string name = Console.ReadLine();
           // how to declare and intilize a boolean variable
           bool keeprunning = false;
            // or 
            bool stoptheloop = true;
            // how to declare and use arrays
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();

            string[] people = { name1,name2,name3 };
            Console.WriteLine(people[0]);// prints the value of name one
            Console.WriteLine(people[1]);// prints the value of name two 
            Console.WriteLine(people[2]);// prints the value of name three

           // how to use the if conditional statement
           if(4 < 5)
            {
                Console.WriteLine("this message was printed because 4 is less then 5");
            }

            bool trueorfalse = true;
            if (trueorfalse)
            {
                Console.WriteLine("this prints is statment is true");

            }
            // how to use the if else conditonal statment
            else
            {
                Console.WriteLine("prints if statment is not true");
            }
            // how to use the switch statment
            int grade = Convert.ToInt32(Console.ReadLine());
            switch (grade)
            {
                case 9:
                    Console.WriteLine("your in grade 9");
                    break;
                    case 10:
                    Console.WriteLine("you are in grade 10");
                    break;
                    case 11:
                    Console.WriteLine("you are in grade 11");
                    break;
                    case 12:
                        Console.WriteLine("you are in grade 12");
                    break;
                default:
                    Console.WriteLine("you are not in highschool");
                    break;
            }
            // how to use the go to labal to create a loop
            int counter = 1;

        beginning:

            Console.WriteLine("this is the" + counter + "time to print this message");

         if (counter > 10) { 
            counter++;
                goto beginning; 
            };
            // how to use loop 
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("this is the" + counter + "time to print this message");
            }
            // how to use loop
            int counter = 1;
            while (counter < 10)
            {
                Console.WriteLine("this is the" + counter + "time to print this message");
              counter++;
            }

            int counter2 = 1;
            bool keeprunning = true;
            while (keeprunning)
            {
                Console.WriteLine("this is the" + counter + "time to print this message");
                counter2++;
                if (counter2 > 10) { keeprunning = false; }
            }
            // how to use do-while loops
            int counter3 = 1;
            do
            {
                Console.WriteLine(counter3);
                counter3++;
            }while (counter3 < 10);


        }
    }
}