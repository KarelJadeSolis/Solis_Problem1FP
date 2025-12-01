
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

                        if (string.IsNullOrEmpty(characterName))
                        {
                            Console.WriteLine("Character is empty");
                        }
                        else if (Movies.ContainsKey(characterName))
                        {
                            Console.WriteLine("No character duplication!");
                        }
                        else
                        {
                            Console.Write("Enter movie title: ");
                            string movieTitle = Console.ReadLine();    
                            Movies.Add(characterName, movieTitle); 
                        }
                        Console.Write("Enter character role: ");
                        string characterRole = Console.ReadLine();

                        Console.Write("Enter signature qoute: ");
                        string signatureQoute = Console.ReadLine();

                        Movies.Add(characterName, characterRole);
                        Movies.Add(characterName,signatureQoute);
                        Console.WriteLine("Character has been added succesfully!");
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
                       // if (myRec.Count == 0)
                       // {
                         //   Console.WriteLine("No Data in the Record Keeping System");
                       // }
                       // else
                       // {
                           // Console.WriteLine("\t-Key\t-Value-");
                           // foreach (KeyValuePair<int, string> i in myD)
                           // {
                           //     Console.WriteLine($"\t{i.Key}\t{i.Value}");
                          //  }
                        //}
                        // break;

                    case 4:

                        return;

                }
                Console.ReadKey();
            }
        }
    }
    
}
