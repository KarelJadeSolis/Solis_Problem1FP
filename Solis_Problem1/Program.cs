
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
                        Console.Write("Enter key to add: ");
                        int keyAdd = Convert.ToInt32(Console.ReadLine());

                        if (myRec.Contains(keyAdd))
                        {
                            Console.WriteLine("No key duplication");
                        }
                        else
                        {
                            Console.Write("Enter value to add: ");
                            string valueAdd = Console.ReadLine();
                            myRec.Add(keyAdd, valueAdd);
                            Console.WriteLine("Data has been succesfully added");
                        }
                        break;

                    case 2:
                        Console.Write("Enter key to remove: ");
                        int key = Convert.ToInt32(Console.ReadLine());

                        if (myRec.Contains(key))
                        {
                            myRec.Remove(key);
                            Console.WriteLine("Data has been succesfully removed");
                        }
                        else
                        {
                            Console.WriteLine("The key does not exist");
                        }
                        break;

                    case 3:
                        if (myRec.Count == 0)
                        {
                            Console.WriteLine("No Data in the Record Keeping System");
                        }
                        else
                        {
                            Console.WriteLine("\t-Key\t-Value-");
                            foreach (KeyValuePair<int, string> i in myD)
                            {
                                Console.WriteLine($"\t{i.Key}\t{i.Value}");
                            }
                        }
                        break;

                    case 4:

                        return;

                }
                Console.ReadKey();
            }
        }
    }
    
}
