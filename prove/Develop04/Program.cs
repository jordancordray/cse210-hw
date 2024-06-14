using System;
using System.Xml.Serialization;
// To exceed the requirements I added an actiity and duration counter which keeps track of how many activities and the duration for the user. It is displayed at the end when the user quits the app.
class Program
{
    static void Main(string[] args)
    {
        int activityCount = 0;
        int durationCount = 0;
        string choice= "1";
        while (choice != "0"){
            Console.Clear();
            Console.WriteLine("Menu options: ");
            Console.WriteLine(" 0. Quit");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflection Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.Write("Choose a menu option: ");
            choice = Console.ReadLine();

            if (choice == "1"){
                BreathingActivity newBreathingActivity = new("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                newBreathingActivity.RunBreathing();
                activityCount ++;
                durationCount += newBreathingActivity.GetDuration();
            }

            else if (choice == "2"){
                ReflectionActivity newReflectionActivity = new("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                newReflectionActivity.RunReflection();
                activityCount++;
                durationCount += newReflectionActivity.GetDuration();
            } 

            else if (choice == "3"){
                ListingActivity newListingActivity = new("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                newListingActivity.RunListing();
                activityCount++;
                durationCount += newListingActivity.GetDuration();
            }
            
        }
        Console.WriteLine($"Thank you for participating in the mindfulness activities. \nYou completed {activityCount} mindfulness activities for a total duration of {durationCount} seconds.");
    }
}