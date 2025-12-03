
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
            while (true)
            {
                Dictionary<string, string> Movies = new Dictionary<string, string>();
                Dictionary<string, string> Roles = new Dictionary<string, string>();
                Dictionary<string, string> Qoutes = new Dictionary<string, string>();

                Console.WriteLine("WELCOME TO MY DISNEY MOVIE CHARACTER TRACKING SYSTEM!");
                Console.WriteLine("1-Add Character");
                Console.WriteLine("2-Edit Character");
                Console.WriteLine("3-Remove Character");
                Console.WriteLine("4-Search Character");
                Console.WriteLine("5-Display Character");
                Console.WriteLine("6-EXIT SYSTEM");

                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter character name: ");
                        string characterName = Console.ReadLine();

                        if (Movies.ContainsKey(characterName) || Roles.ContainsKey(characterName) || Qoutes.ContainsKey(characterName))
                        {
                            Console.WriteLine("Character name should not be empty!");
                        }
                        else if (string.IsNullOrWhiteSpace(characterName))
                        {
                            Console.WriteLine("No character name duplication!");
                        }
                        else 
                        {
                            Console.Write("Enter movie title: ");
                            string movieTitle = Console.ReadLine();
                            Movies.Add(characterName, movieTitle);
                            
                            Console.Write("Enter character role: ");
                            string characterRole = Console.ReadLine();
                            Roles.Add(characterName, characterRole);

                            Console.Write("Enter signature qoute: ");
                            string signatureQoute = Console.ReadLine();
                            Qoutes.Add(characterName, signatureQoute);

                            Console.WriteLine("Character has been added succesfully!");
                        }
                        
                        break;

                        
                    //case 2:
                        Console.Write("Enter character name to remove: ");
                        string characterNameRemove = Console.ReadLine();

                       // if (myRec.ContainsKey(key))
                     //   {
                        //    myRec.Remove(key);
                        //    Console.WriteLine("Data has been succesfully removed");
                       // }
                        //else
                        //{
                         //   Console.WriteLine("The key does not exist");
                       // }
                      //  break;

                   // case 3:
                       
                        // break;

                    case 4:

                        return;
                    case 5:
                        if (Movies.Count == 0)
                        {
                            Console.WriteLine("No Data in the Record Keeping System");
                        }
                        else
                        {
                            Console.WriteLine("\t-Key\t-Value-");
                            foreach (KeyValuePair<string, string> i in Movies)
                            {
                                Console.WriteLine($"\t{i.Key}\t{i.Value}");
                            }
                        }
                        break;

                }
                Console.ReadKey();
            }
        }
    }
    
}
