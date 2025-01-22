// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using Mission3;

FoodItem item;
FoodItem[] inventory = new FoodItem[0];
string name = "";
string category = "";
int quantity = 0;
string expireDate = "";

Console.WriteLine("Welcome to the Foodbank Management Index Tool!");
Console.Write("Would you like to add (A) a new item or delete (D) an existing item? (A/D): ");
string response1 = Console.ReadLine();

if (response1.IsNullOrEmpty() || response1.ToUpper() != "A" || response1.ToUpper() != "D") 
{
    handleRequest(response1);
}
else {
    Console.Write();
}

public void handleRequest(string option)
{
        
}
    
// ADD ITEM
    
// DELETE ITEM

// PRINT CURRENT LIST ITEMS


// EXIT PROGRA

item = new FoodItem(name, category, quantity, expireDate);