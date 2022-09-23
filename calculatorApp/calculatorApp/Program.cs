internal class Program
{
    private static void Main(string[] args)
    {


        bool flag = true;





        int answer = 0;

        while (flag)
        {
            Console.WriteLine("Enter the option to perform an operation: ");
            Console.WriteLine("Enter 1 for addition");
            Console.WriteLine("Enter 2 for subtraction");
            Console.WriteLine("Enter 3 for multiplication");
            Console.WriteLine("Enter 4 for division");
            Console.WriteLine("Enter 5 to stop the program");

            
            int userChoice = Convert.ToInt32(Console.ReadLine());

            int num1=0;
            int num2=0;


            if (userChoice != 5)
            {
                Console.WriteLine("Please enter the first number");
                num1 = Convert.ToInt32(Console.ReadLine());

                // ASSUME the user only enters integer numbers
                Console.WriteLine("Please enter the second number ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }





            switch (userChoice)
                {
                    case 1:
                        answer = num1 + num2;
                        break;
                    case 2:
                        answer = num1 - num2;
                        break;
                    case 3:
                        answer = num1 * num2;
                        break;
                    case 4:
                        answer = num1 / num2;
                        break;
                    case 5:
                    Console.WriteLine("Thank You for using this application, have a great day ahead :)");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Wrong user Input");
                        break;

                }

            if (userChoice != 5)
            {
                Console.WriteLine("The answer is: " + answer);
            }
             
            
        }
    }
}