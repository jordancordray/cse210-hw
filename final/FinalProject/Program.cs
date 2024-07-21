using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        UserInterface UI = new();
        UI.LoadInventory();
        string choice = "";
        while (choice != "0" ){
            choice = UI.Menu();

            if (choice == "1"){
               UI.DisplayInventory();
            }
            else if (choice == "2"){
                Console.Clear();
                UI.PlaceOrder();
            }
            else if (choice == "3"){
                Console.Clear();
                UI.DoCount();
            }
            else if (choice == "4"){
                Console.Clear();
                UI.DoCustomerOrders();
            }
            else if (choice == "5"){
                
            }
        }
        UI.SaveInventory();
    }
}