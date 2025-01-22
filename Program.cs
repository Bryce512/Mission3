// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Diagnostics;
using Mission3;

internal class Program
    {
        public static FoodItem item;
        public static List<FoodItem> inventory = new List<FoodItem>();
        public static string name = "";
        public static string category = "";
        public static int quantity = 0;
        public static DateTime expireDate;
        public static string option = "";
        public static string[] options = ["1: Add Item", "2: Delete Item", "3: View Inventory", "4: Exit Program"];
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Foodbank Management Tool!");
            GetRequest();
        }
        static void GetRequest()
        {
            Console.WriteLine("What would you like to do?");
            foreach(string i in options)
            {
                Console.WriteLine(i);
            }
            Console.Write("Option #: ");
            option = Console.ReadLine();
            Console.WriteLine("");

            

            if (option == "")
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter a response.");
                Console.WriteLine("");

                GetRequest();
            } 
            else if (option is "1" or "2" or "3" or "4") 
            {
                HandleRequest(option);
            }
            else {
                Console.WriteLine("Please enter a valid response.");
                Console.WriteLine("");
                GetRequest();
            }
        }

        static void HandleRequest(string option)
        {
            switch (option)
            {
                case "1":
                    AddItem();
                    break;
                case "2":
                    DeleteItem();
                    break;
                case "3":
                    ViewInventory();
                    break;
                case "4":
                    ExitProgram();
                    break;
            }
        }

// ADD ITEM
        static void AddItem(){
            Console.Write("What is the Name of the item? ");
            name = Console.ReadLine().ToUpper();
            Console.Write("What is the Category of the item? ");
            category = Console.ReadLine().ToUpper();
            Console.Write("What is the Quantity of the item? ");
            quantity = int.Parse(Console.ReadLine());
            Console.Write("What is the Expiration Date (MM/DD/YYYY) of the item? ");
            expireDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("");

            item = new FoodItem(name, category, quantity, expireDate);
            inventory.Add(item);
            NextStep();
        }

// DELETE ITEM
        static void DeleteItem()
        {
            Console.Write("Enter the name of the item would you like to delete? ");
            name = Console.ReadLine().ToUpper();

            for(int i = 0; i < inventory.Count; i++)
            {
                if (name.ToUpper() == inventory[i].Name)
                {
                    inventory.Remove(inventory[i]);
                    Console.WriteLine(name + " has been deleted.");
                    Console.WriteLine("");
                    Console.WriteLine("");


                }
            }
            NextStep();
        }
// VIEW INVENTORY
        static void ViewInventory(){
            if (inventory.Count == 0)
            {
                Console.WriteLine("There is nothing in inventory available.");
                Console.WriteLine("");
                Console.WriteLine("");
                NextStep();
            }
            else
            {
                foreach (FoodItem i in inventory)
                {
                    Console.Write(i.Name + " ");
                    Console.Write(" Expires: " + i.ExpireDate);
                    Console.Write("  Quantity: " + i.Quantity);
                    Console.WriteLine("  Category: " + i.Category);
                }
                Console.WriteLine("");
                Console.WriteLine("");
                NextStep();
            }
            
        }
        
// GET NEXT STEP (view options again or exit?)
        static void NextStep()
        {
            Console.WriteLine("What would you like to do next?");
            Console.WriteLine("1: Add/Delete/View Inventory");
            Console.WriteLine("2: Exit Program");
            Console.Write("Option #: ");
            option = Console.ReadLine();
            Console.WriteLine("");

            if (option == "1")
            {
                GetRequest();
            } else if (option == "2")
            {
                ExitProgram();
            } else
            {
                Console.WriteLine("Please enter a valid response.");
                NextStep();
            }
        }
// EXIT PROGRAM
        static void ExitProgram()
        {
            Console.WriteLine("Thank you for using the Foodbank Management Tool!");
            Console.WriteLine("");
            Environment.Exit(0);
        }
    }
    
