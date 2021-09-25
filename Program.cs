using System;

namespace EigenesProjekt_Petit_SiriguElisa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int secretNumber = random.Next(1, 100);

            try
            {

                Console.WriteLine("Wählen Sie eine Sprache / Choose a language: ");
                Console.WriteLine("Für Deustch wählen Sie die 1 und klicken auf Enter / For English write 2 and press Enter");

                string selection = Console.ReadLine();
                int z = Int32.Parse(selection);

                if (z == 1)
                {
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("Herzlich willkommen zu meinem ersten, selbst programmierten Minigame. Ihre Aufgabe ist es, die Geheimzahl zu erraten.");
                    Console.WriteLine("Überlegen Sie sich eine Zahl zwischen 1 und 100.");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.Write("Schreiben Sie hier Ihre Zahl und drücken Sie dann die Entertaste: ");
                    string userinput = Console.ReadLine();
                    int x = Int32.Parse(userinput);

                    int attemps = 0;

                    if (x < 1 || x > 100)
                    {
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Ungültige Eingabe, bitte erneut um eine Zahl zwischen 1 und 100.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (x != secretNumber)
                    {
                        if (x < secretNumber)
                        {
                            Console.WriteLine("Ihre Zahl ist zu klein.");
                            Console.WriteLine("Versuchen Sie es noch einmal:");
                            Console.WriteLine("-------------------------------------------------------------");

                        }
                        else if (x > secretNumber)
                        {
                            Console.WriteLine("Ihre Zahl ist zu gross");
                            Console.WriteLine("Versuchen Sie es noch einmal:");
                            Console.WriteLine("-------------------------------------------------------------");
                        }

                        x = Int32.Parse(Console.ReadLine());
                        attemps = attemps + 1;
                    }
                    
                    if (x == secretNumber)
                    {
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(x);
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("Super! Sie haben die Geheimzahl erraten.");
                        Console.WriteLine("Drücken Sie Enter, um Ihre Rateversuche anzeigen zu lassen.");
                        Console.WriteLine("Sie haben " + attemps + " Versuche gebraucht.");
                    }
                }
                if (z == 2)
                {
                    Console.WriteLine("Welcome too my minigame called TheSecretNumber. Your yob is, to guess the secret number. Good luck ;)");
                    Console.WriteLine("Write a number between 1 an 100");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.Write("Write your number right here and press Enter: ");
                    string userinput = Console.ReadLine();
                    int x = Int32.Parse(userinput);

                    int attempts = 0;

                    if (x < 1 || x > 100)
                    {
                        Console.WriteLine("Wrong entry! Please write a number between 1 and 100.");
                    }

                    while (x != secretNumber)
                    {
                        if (x < secretNumber)
                        {
                            Console.WriteLine("Your number is too small.");
                            Console.WriteLine("Try again:");
                            Console.WriteLine("-------------------------------------------------------------");
                        }
                        else if (x > secretNumber)
                        {
                            Console.WriteLine("Your number is too big.");
                            Console.WriteLine("Try again:");
                            Console.WriteLine("-------------------------------------------------------------");
                        }
                        x = Int32.Parse(Console.ReadLine());
                        attempts = attempts + 1;
                    }

                    if (x == secretNumber)
                    {
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(x);
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("Awesome! You guessed the right number.");
                        Console.WriteLine("Press Enter to show your attempts");
                        Console.WriteLine("It took you " + attempts + " attempts to guess the secret number.");
                    }
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ERROR. Geben Sie bitte eine Zahl ein!");
                Console.WriteLine("Write a number!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
