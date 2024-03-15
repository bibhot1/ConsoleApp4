namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nested if statements
            Console.WriteLine("Enter your name");
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            userName = Console.ReadLine();

           /* if (isRegistered)
            {
                Console.WriteLine("Hi there, registered user");
                if (userName != "")
                {
                    Console.WriteLine("Hi there, "+ userName);

                    if (userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hi there , Admin");
                    }
                }
            }
           */

            // making the if statement simpler

            if (isRegistered && userName != "" && userName.Equals("Admin"))
            {
                Console.WriteLine("Hi there, registered user");
                Console.WriteLine("Hi there, " + userName);
                Console.WriteLine("Hi there , Admin");
            }
            //Comparisions with or
            if(isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }

        }
    }
}
