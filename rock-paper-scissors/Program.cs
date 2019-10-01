using System;

namespace rock_paper_scissors2
{

    class Program
    {
        static void Main(string[] args)
        {
            bool state;
            state = true;
            int computer_points;
            computer_points = 0;
            int player_points;
            player_points = 0;
            while (state)
            {
                if (computer_points == 3)
                {
                    Console.WriteLine("Computer won with getting 3 points meanwhile you got " + player_points.ToString() + " point(s).");
                    state = false;
                }
                else if (player_points == 3)
                {
                    Console.WriteLine("You won with getting 3 points meanwhile computer got " + computer_points.ToString() + " point(s).");
                    state = false;
                }
                else
                {
                    Console.WriteLine("Let's play rock-paper-scissors. Please type your answer");
                    string player_choice;
                    player_choice = Console.ReadLine();
                    var random = new Random();
                    int computer_choice = random.Next(1, 4);
                    if (computer_choice== 1)
                    {
                        Console.WriteLine("Computer chose rock.");
                        if (player_choice == "rock")
                        {

                            Console.WriteLine("It's a tie! Noone gets a point.");
                        }
                        else if (player_choice == "paper")
                        {
                            Console.WriteLine("You won! You get a point.");
                            player_points++;
                        }
                        else
                        {
                            Console.WriteLine("You lost! Computer gets a point");
                            computer_points++;
                        }
                    }
                    else if (computer_choice == 2)
                    {
                        Console.WriteLine("Computer chose paper.");
                        if (player_choice == "rock")
                        {
                            Console.WriteLine("You lost! Computer gets a point.");
                            computer_points++;
                        }
                        else if (player_choice == "paper")
                        {
                            Console.WriteLine("It's a tie! Noone gets a point.");
                        }
                        else
                        {
                            Console.WriteLine("You won! You get a point.");
                            player_points++;
                        }
                    }
                    else if (computer_choice == 3)
                    {
                        Console.WriteLine("Computer chose scissors.");
                        if (player_choice == "rock")
                        {
                            Console.WriteLine("You won! You get a point.");
                            player_points++;
                        }
                        else if (player_choice == "paper")
                        {
                            Console.WriteLine("You lost! Computer gets a point.");
                            computer_points++;
                        }
                        else
                        {
                            Console.WriteLine("It's a tie Noone gets a point.");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}