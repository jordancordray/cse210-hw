using System;
using System.ComponentModel.Design;
using System.Xml.Serialization;

class Program
{
// I added a level class which gives the user a level based on how many points they get. The levels get harder with an increase of points each time a level is created. 
    static void Main(string[] args)
    {
        UserInterface UI = new();
        string choice = "";
        while (choice != "0" ){
            choice = UI.Menu();

            if (choice == "1"){
                UI.CreateGoal();
            }
            else if (choice == "2"){
                UI.DisplayGoals();
            }
            else if (choice == "3"){
                UI.Save();
            }
            else if (choice == "4"){
                UI.Load();
            }
            else if (choice == "5"){
                UI.FindEvent();
            }
        }
    }
}