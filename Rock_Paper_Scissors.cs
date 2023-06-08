// This is a rock paper scissors game developed by Me, Hishaam Mehmood using the C# language.


using System; //allows us to access the systems library



namespace RockPaperScissors
{
    public class Game //this is our game class
    {
        public const int Maxplayers = 1;

        public static string[] Players = new string[1];


        public static void Main() //this is our main method
        {
            MenuSelection();  //the main method will be displayed
        }
        public static void MenuSelection() //this is our main menu selection method
        {
            int selection = 0;

            Console.ForegroundColor = ConsoleColor.Blue; //the console output text shall be blue.
            Console.WriteLine(" Welcome to Hishaam's Rock paper scissors game! ");
            Console.WriteLine(" ---------------------------------------------- ");
            Console.WriteLine(" Please select an option from below: ");
            Console.WriteLine(" ---------------------------------------------- ");
            Console.WriteLine(" 1. Start game ");
            Console.WriteLine(" 2. quit game ");
            Console.WriteLine(" ---------------------------------------------- ");
            Console.WriteLine(" Your choice is: ");
            Console.WriteLine(" ---------------------------------------------- ");

            try
            {
                string choice = Console.ReadLine(); //reads the user input.

                selection = Convert.ToInt32(choice);

                //our switch statement begins below:

                switch (selection)
                {
                    case 1:
                        StartGame(); //the first option starts the game
                        break;

                    case 2:
                        Quit(); //the second option quits the game
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(" Your input is invalid "); //if the user enters an invalid value, they will be met with an error code.
            }

        }

        public static void StartGame() //this is our start game method
        {


            for (int index = 0; index < Maxplayers; index++)
            {
                Console.WriteLine(" ---------------------------------------------- ");
                Console.WriteLine(" Please enter your name: "); //the user is asked to enter their name.
                Console.WriteLine(" ---------------------------------------------- ");
                Players[index] = Console.ReadLine(); //awaits user input

                Console.WriteLine(" ---------------------------------------------- ");
                Console.WriteLine(" Hello " + Players[index] + " This is a game of rock paper scissors. "); 
                Console.WriteLine(" ---------------------------------------------- ");
                Console.WriteLine(" The rules of the game are as follows: ");
                Console.WriteLine(" 1. the game will be best out of 3. ");
                Console.WriteLine(" 2. Rock beats scissors. ");
                Console.WriteLine(" 3. Scissors beats paper ");
                Console.WriteLine(" 4. Paper beats rock. ");
                Console.WriteLine(" 5. If a round ends with both the player and the CPU making the same choice, it shall end in a draw and no points will be awarded. ")


                string userInput; //will be used for our player input
                string cpuInput; // this will be used for our computer input

                int randomInt; // this will be our randomiser integar.

                bool restartGame = true; //this is our restart boolean, it will allow the user to restart the game upon finishing.

                while (restartGame)
                {
                    int scoreUser = 0;
                    int scoreCPU = 0;


                    while (scoreUser < 3 && scoreCPU < 3) // the scores have a maximum value of 3
                    {
                        Console.WriteLine(" ---------------------------------------------- ");
                        Console.WriteLine(" Please select an option: ");
                        Console.WriteLine(" ---------------------------------------------- ");
                        Console.WriteLine(" Rock ");
                        Console.WriteLine(" Paper ");
                        Console.WriteLine(" Scissors ");
                        Console.WriteLine(" ---------------------------------------------- ");
                        Console.WriteLine(" Your choice is: ");
                        Console.WriteLine(" ---------------------------------------------- ");

                        userInput = Console.ReadLine();

                        Random rndm = new Random(); //this allows us to randomise the choices

                        randomInt = rndm.Next(1, 4);

                        switch (randomInt)
                        {
                            case 1:
                                cpuInput = "Rock"; 
                                Console.WriteLine(" CPU chose Rock. ");
                                Console.WriteLine(" ---------------------------------------------- ");

                                if (userInput == "Rock")  
                                {
                                    Console.WriteLine(" it is a Draw. "); //ion the event that the user makes the same choice as the CPU, it will be a draw. 
                                    Console.WriteLine(" ---------------------------------------------- ");

                                }
                                else if (userInput == "Paper ")

                                {
                                    Console.WriteLine(Players[index] + " wins!");
                                    Console.WriteLine(" ---------------------------------------------- ");
                                    scoreUser++; //the winner recieves a point

                                }
                                else if (userInput == "Scissors")
                                {
                                    Console.WriteLine(" CPU wins!");
                                    Console.WriteLine(" ---------------------------------------------- ");
                                    scoreCPU++;

                                }
                                break;

                            case 2:

                                cpuInput = "Paper";
                                Console.WriteLine(" CPU chose Paper ");
                                Console.WriteLine(" ---------------------------------------------- ");
                                if (userInput == "Paper")
                                {
                                    Console.WriteLine(" it is a Draw.");

                                }
                                else if (userInput == "Rock")
                                {
                                    Console.WriteLine(" CPU wins!");
                                    Console.WriteLine(" ---------------------------------------------- ");
                                    scoreCPU++;

                                }
                                else if (userInput == "Scissors")
                                {
                                    Console.WriteLine(Players[index] + " wins! ");
                                    Console.WriteLine(" ---------------------------------------------- ");
                                    scoreUser++;
                                }
                                break;

                            case 3:

                                cpuInput = "Scissors";
                                Console.WriteLine(" CPU chose Scissors ");
                                Console.WriteLine(" ---------------------------------------------- ");

                                if (userInput == "Scissors")
                                {
                                    Console.WriteLine(" it is a Draw.");
                                    Console.WriteLine(" ---------------------------------------------- ");

                                }
                                else if (userInput == "Rock")
                                {
                                    Console.WriteLine(Players[index] + " wins! ");
                                    Console.WriteLine(" ---------------------------------------------- ");
                                    scoreUser++;
                                }
                                else if (userInput == "Paper")
                                {
                                    Console.WriteLine(" CPU wins! ");
                                    Console.WriteLine(" ---------------------------------------------- ");
                                    scoreCPU++;
                                }
                                break;

                            default:

                                Console.WriteLine(" Invalid input ");

                                break;
                        }

                     Console.WriteLine("\n\nSCORES:"+ Players[index] + "\t{0}\tCPU:\t{1}", scoreUser, scoreCPU); //after every round, the scoreboard is updated

                    }

                    if (scoreUser == 3) //if the user has a score of 3, they have won the game. 
                    {
                     Console.WriteLine(Players[index] + " has won the game!");
                     Console.WriteLine(" ---------------------------------------------- ");

                    }
                    else if (scoreCPU == 3) //if the CPU has a score of 3, it has won the game. 
                    {
                     Console.WriteLine(" CPU has won the game!");
                     Console.WriteLine(" ---------------------------------------------- ");
                    }

                     Console.WriteLine(" Would you like to play again? (y/n)"); //the user is asked if they wish to play again.
                     Console.WriteLine(" ---------------------------------------------- ");

                    string loop = Console.ReadLine();

                    if (loop == "y") //if the user enters y, the game shall restart
                    {
                        restartGame = true;
                        Console.Clear();
                    }
                    else if (loop == "n") //if the user eneters n, they are led back to the main menu. 
                    {
                        restartGame = false;
                        MenuSelection();
                    }

                }
            }

        }
        public static void Quit()
        {
            Console.Clear(); //clears the console window
        }

    }
}