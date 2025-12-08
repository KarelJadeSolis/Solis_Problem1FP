
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
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
            Dictionary<string, string> Quotes = new Dictionary<string, string>();
            
            int choice; // I asked AI on how to validate the user input(choice) if its in null or white space so the program wouldn't crash after using a data type int.                   
                      
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("WELCOME TO MY DISNEY MOVIE CHARACTER TRACKING SYSTEM!");
                Console.WriteLine("NOTE: Please capitalize the first letter of each name, title, and role when entering or viewing information.");
                Console.WriteLine("1-Display Character");
                Console.WriteLine("2-Add Character");
                Console.WriteLine("3-Edit Character");
                Console.WriteLine("4-Remove Character");
                Console.WriteLine("5-Search Character");
                Console.WriteLine("6-Exit System");
                Console.WriteLine("");
               

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice))
                {
                    if (choice >= 1 && choice <= 6)
                    {
                        switch (choice)
                        {
                            case 1:

                                if (Movies.Count == 0)
                                {
                                    Console.WriteLine("There is no Disney Movie Character List in the Character Tracking System!");
                                    Console.WriteLine("Press enter to return to the menu........");
                                    Console.ReadKey(); // I asked AI on how to pause the console until user presses a key.
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("DISNEY MOVIE CHARACTER LIST:");
                                    Console.WriteLine("---------------------------------------------");
                                    foreach (KeyValuePair<string, string> k in Movies)
                                    {     
                                         string name = k.Key;
                                         string title = k.Value;
                                         string role = Roles.ContainsKey(name) ? Roles[name] : "N/A"; // I asked AI on how to get the value of a dictionary in order to print the role and signature qoute.
                                         string quote = Quotes.ContainsKey(name) ? Quotes[name] : "N/A";

                                        Console.WriteLine($"Character Name: {name}\n" +
                                                          $"Movie Title: {title}\n" +
                                                          $"Character Role: {role}\n" +
                                                          $"Signature Quote: {quote}\n");
                                    }
                                    Console.WriteLine("Press enter to return to the menu........");
                                    Console.ReadKey();
                                }
                                break;

                            case 2:        
                                Console.Write("Enter character name: ");
                                string characterName = Console.ReadLine();
                                
                                if (string.IsNullOrWhiteSpace(characterName))
                                {
                                    Console.WriteLine("Character name cannot be empty. Please enter again.");
                                }
                                else if (Movies.ContainsKey(characterName))
                                {
                                    Console.WriteLine("No character name duplication! Please enter again.");
                                }
                                else
                                {
                                    while (true)
                                    {
                                        Console.Write("Enter movie title: ");
                                        string movieTitle = Console.ReadLine();

                                        if (string.IsNullOrWhiteSpace(movieTitle))
                                        {
                                            Console.WriteLine("Movie title name cannot be empty. Please enter again.");

                                        }
                                        else
                                        {
                                            Movies.Add(characterName, movieTitle);
                                            break;
                                        }
                                    }
                                    while (true)
                                    {
                                        Console.Write("Enter character role (Protagonist, Antagonist, Sidekick, Supporting): ");
                                        string characterRole = Console.ReadLine();

                                        if (characterRole == "Protagonist" || characterRole == "Sidekick" || characterRole == "Antagonist" || characterRole == "Supporting")
                                        {
                                            Roles.Add(characterName, characterRole);

                                            while (true)
                                                {
                                                    Console.Write("Enter signature quote: ");
                                                    string signatureQoute = Console.ReadLine();

                                                    if (string.IsNullOrWhiteSpace(signatureQoute))
                                                    {
                                                        Console.WriteLine("Signature Quote cannot be empty. Please enter again.");
                                                    }
                                                    else
                                                    {
                                                        Quotes.Add(characterName, signatureQoute);
                                                        Console.WriteLine("Character has been added successfully!");
                                                        Console.WriteLine("Press enter to return to the menu........");
                                                        Console.ReadKey();
                                                    break;
                                                    }
                                            }
                                            break;
                                        }
                                        else if (string.IsNullOrWhiteSpace(characterRole))
                                        {
                                            Console.WriteLine("Character Role cannot be empty! Please enter again.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Character Role should only be [Protagonist][Sidekick][Antagonist][Supporting]. Please capitalize first letter.");
                                        }
                                    }
                                }
                                break;

                            case 3:
                                while (true)
                                {
                                    if (Movies.Count == 0)
                                    {
                                        Console.WriteLine("There is no Disney Movie Character List in the Character Tracking System!");
                                        Console.WriteLine("Press enter to return to the menu........");
                                        Console.ReadKey();
                                        break;
                                    }

                                    Console.Write("Enter character name to edit: ");
                                    string characterToEdit = Console.ReadLine();

                                    if (string.IsNullOrWhiteSpace(characterToEdit))
                                    {
                                        Console.WriteLine("Invalid input! Character name cannot be empty. Please enter again.");
                                    }
                                    else if (!Movies.ContainsKey(characterToEdit))
                                    {
                                    Console.WriteLine("The character name does not exist in the tracking system.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Editing Character: " + characterToEdit);

                                        Console.Write($"Enter new movie title: ");
                                        string newTitle = Console.ReadLine();
                                        if (!string.IsNullOrWhiteSpace(newTitle))
                                        {
                                            Movies[characterToEdit] = newTitle; 
                                        }

                                        Console.Write($"Enter new character role (Protagonist, Antagonist, Sidekick, Supporting): ");
                                        string newRole = Console.ReadLine();
                                        
                                        if (!string.IsNullOrWhiteSpace(newRole))
                                        {
                                            if (newRole == "Protagonist" || newRole == "Antagonist" || newRole == "Sidekick" || newRole == "Supporting")
                                            {
                                                Roles[characterToEdit] = newRole;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid role! Keeping the previous role.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Role cannot be empty! Keeping the previous role.");
                                        }

                                        Console.Write($"Enter new signature quote: ");
                                        string newQoute = Console.ReadLine();
                                        if (!string.IsNullOrWhiteSpace(newQoute))
                                        {
                                            Quotes[characterToEdit] = newQoute;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Signature Qoute cannot be empty! Keeping the previous signature qoute.");
                                        }

                                        Console.WriteLine("Character information has been updated!");
                                        Console.WriteLine("Press enter to return to the menu........");
                                        Console.ReadKey();
                                        break;
                                    }
                                    
                                }
                                break;

                            case 4:
                                while (true)
                                {
                                    if (Movies.Count == 0)
                                    {
                                        Console.WriteLine("There is no Disney Movie Character List in the Character Tracking System!");
                                        Console.WriteLine("Press enter to return to the menu........");
                                        Console.ReadKey();
                                        break;
                                    }

                                    Console.Write("Enter character name to remove: ");
                                    string characterNameRemove = Console.ReadLine();

                                    if (Movies.ContainsKey(characterNameRemove))
                                    {
                                        Movies.Remove(characterNameRemove);
                                        Roles.Remove(characterNameRemove);
                                        Quotes.Remove(characterNameRemove);
                                        Console.WriteLine("Disney Character has been succesfully removed.");
                                        Console.WriteLine("Press enter to return to the menu........");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else if (string.IsNullOrWhiteSpace(characterNameRemove))
                                    {
                                        Console.WriteLine("Invalid input! Character name cannot be empty.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The Disney Character name does not exist.");
                                    }
                                }
                            break;

                            case 5:
                                while (true) 
                                {
                                    if (Movies.Count == 0)
                                    {
                                        Console.WriteLine("There is no Disney Movie Character List in the Character Tracking System!");
                                        Console.WriteLine("Press enter to return to the menu........");
                                        Console.ReadKey();
                                        break;
                                    }

                                    Console.Write("Enter character name to search: ");
                                    string characterNameSearch = Console.ReadLine();

                                    if (Movies.ContainsKey(characterNameSearch))
                                    {
                                        Console.WriteLine("Here is the information below: ");
                                        Console.WriteLine("");
                                            string title = Movies[characterNameSearch];
                                            string role = Roles.ContainsKey(characterNameSearch) ? Roles[characterNameSearch] : "N/A"; 
                                            string quote = Quotes.ContainsKey(characterNameSearch) ? Quotes[characterNameSearch] : "N/A";

                                            Console.WriteLine($"Character Name: {characterNameSearch}\n" +
                                                              $"Movie Title: {title}\n" +
                                                              $"Character Role: {role}\n" +
                                                              $"Signature Quote: {quote}\n");
                                            Console.WriteLine("");
                                            Console.WriteLine("Press enter to return to the menu........");
                                            Console.ReadKey();
                                            break;
                                    }
                                    else if (string.IsNullOrWhiteSpace(characterNameSearch))
                                    {
                                        Console.WriteLine("Invalid input! Character name cannot be empty. Please enter again.");
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The character name you have entered does not exist in the tracking system.");
                                    }
                                        
                                }             
                            break;

                            case 6:
                                Console.WriteLine("Exiting the system. Thank you!");
                                return;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a number between 1 and 6.");
                    }
                }
                else 
                { 
                    Console.WriteLine("Invalid input! Please enter a number.");
                }
                
            }
            
        }   
    }
}
    

