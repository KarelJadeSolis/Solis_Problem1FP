
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solis_Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Movies = new Dictionary<string, string>();    
            Dictionary<string, string> Roles = new Dictionary<string, string>();
            Dictionary<string, string> Qoutes = new Dictionary<string, string>();
            
            int choice; // I asked AI on how to validate the user input(choice) if its in null or white space so the program wouldn't crash after using a data type int where in,
                        // it suggested me to do int.tryparse method and I asked how to use it.
                      
            while (true)
            {
                Console.WriteLine("WELCOME TO MY DISNEY MOVIE CHARACTER TRACKING SYSTEM!");
                Console.WriteLine("1-Display Character");
                Console.WriteLine("2-Add Character");
                Console.WriteLine("3-Edit Character");
                Console.WriteLine("4-Remove Character");
                Console.WriteLine("5-Search Character");
                Console.WriteLine("6-EXIT SYSTEM");

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice))
                {
                    if (choice >= 1 || choice <= 6)
                    {
                        switch (choice)
                        {
                            case 1:

                                if (Movies.Count == 0)
                                {
                                    Console.WriteLine("No Disney Movie in the Character Tracking System!");
                                }
                                else
                                {

                                    foreach (KeyValuePair<string, string> k in Movies)
                                    {
                                        Console.WriteLine($"Character Name: {k.Key}\n" +
                                                          $"Movie Title: {k.Value}");
                                    }

                                    foreach (KeyValuePair<string, string> j in Roles)

                                    {
                                        Console.WriteLine($"Character Role: {j.Value}");
                                    }

                                    foreach (KeyValuePair<string, string> s in Qoutes)
                                    {
                                        Console.WriteLine($"Signature Qoute: {s.Value}");
                                    }
                                }
                                break;

                            case 2:
                                Console.Write("Enter character name: ");
                                string characterName = Console.ReadLine();

                                if (string.IsNullOrWhiteSpace(characterName))
                                {
                                    Console.WriteLine("Character name should not be empty!");
                                }
                                else if (Movies.ContainsKey(characterName) || Roles.ContainsKey(characterName) || Qoutes.ContainsKey(characterName))
                                {
                                    Console.WriteLine("No character name duplication!");
                                }
                                else
                                {
                                    while (true)
                                    {
                                        Console.Write("Enter movie title: ");
                                        string movieTitle = Console.ReadLine();

                                        if (string.IsNullOrWhiteSpace(movieTitle))
                                        {
                                            Console.WriteLine("Movie title name should not be empty!");

                                        }
                                        else
                                        {
                                            Movies.Add(characterName, movieTitle);
                                            break;
                                        }
                                    }
                                    while (true)
                                    {
                                        Console.Write("Enter character role: ");
                                        string characterRole = Console.ReadLine().ToUpper();

                                        if (characterRole == "PROTAGONIST" || characterRole == "SIDEKICK" || characterRole == "ANTAGONIST" || characterRole == "SUPPORTING")
                                        {
                                            Roles.Add(characterName, characterRole);

                                            while (true)
                                            {
                                                Console.Write("Enter signature qoute: ");
                                                string signatureQoute = Console.ReadLine();

                                                if (string.IsNullOrWhiteSpace(signatureQoute))
                                                {
                                                    Console.WriteLine("Signature Qoute should not be empty!");
                                                }
                                                else
                                                {
                                                    Qoutes.Add(characterName, signatureQoute);

                                                    Console.WriteLine("Character has been added succesfully!");
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                        else if (string.IsNullOrWhiteSpace(characterRole))
                                        {
                                            Console.WriteLine("Character Role should not be empty!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Character should only be [Protagonist][Sidekick][Antagonist][Supporting]");
                                        }
                                    }
                                }
                                break;

                            case 3:
                                break;

                            case 4:
                                while (true)
                                {
                                    Console.Write("Enter character name to remove: ");
                                    string characterNameRemove = Console.ReadLine();

                                    if (Movies.ContainsKey(characterNameRemove))
                                    {
                                        Movies.Remove(characterNameRemove);
                                        Roles.Remove(characterNameRemove);
                                        Qoutes.Remove(characterNameRemove);
                                        Console.WriteLine("Disney Character has been succesfully removed");
                                    }
                                    else if (string.IsNullOrWhiteSpace(characterNameRemove))
                                    {
                                        Console.WriteLine("Enter character name to remove.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The Disney Character does not exist");
                                    }
                                }
                                break;

                            case 6:
                                Console.WriteLine("Exiting the system. Thankyou!");
                                return;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid! Please enter a number between 1 and 6.");
                    }
                }
                else 
                { 
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
                
            }
            
        }   
    }
}
    

