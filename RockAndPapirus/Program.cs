using System.Xml;

class program
{
    public static void Main(string[] args)
    {
       Console.WriteLine("hello");
       Console.WriteLine("Make a choise");
       Console.WriteLine("1-Rock" + " " + "- 2- scissors" + " " + " 3 - Paper");
       
       Random rnd = new Random();
       
       //генерируем число для компьютера 
       // парсим пользвательский ввод
        string b = Console.ReadLine();
        int userChoice = Int32.Parse(b);
      
        int computerChoice = rnd.Next(1, 4);
        
        
      
        while (true)
        {
            if (userChoice == computerChoice)
            {
                Console.WriteLine("Draw!");
            }
            else if (userChoice == 1 && computerChoice == 2 || userChoice == 2 && computerChoice == 3
                                                            || userChoice == 3 && computerChoice == 1)
            {
                Console.WriteLine("you won");
            }
            else
            {
                Console.WriteLine("you lost" + " " + "Computer win!");
            }

            string g = Console.ReadLine();
            if (g != "9")
            {
              break;
            }

            Console.WriteLine("Thank you for playing!");
        }
        
    }
}