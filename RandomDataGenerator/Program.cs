using RandomDataGenerator;
using System;

public class Program
{
    static List<Person> group = new List<Person>(); 
    public static void Main(string[] args)
    {//switch to the menu output above
        var ans = 0;
        ans = Int32.Parse(Console.ReadLine());
        do
        {
            Menu();
            ans = Int32.Parse(Console.ReadLine());
            BackMenu(ans);


        } while (ans != 0);


    }
    public static void Menu()
    { 
        Console.WriteLine("Would you like to create a imaginary friend and/or friends? Press 1 to create your first friend");
        Console.WriteLine("Type 1. to make your friends.");
        Console.WriteLine("Type 2. to view your friends.");
        Console.WriteLine("Type 3. to make a random imaginary last name. ");
        Console.WriteLine("Type 4. to display an imaginary Social Security Information.");
        Console.WriteLine("Type 5. to display an imaginary friends phone number and seperate it as you please.");
        Console.WriteLine("If you wish to exit type 0.");
    }
    public static void BackMenu(int ans)
    {
        Random rand = new Random();
        switch (ans)
        {
            
            //Friend Viewer
            case 1:
                group.Add(new Person());
                break;
            //view friends
            case 2:
                foreach (Person p in group)
                {
                    Console.WriteLine(p);
                }
                break;
            //remove friend
            case 3:
                Console.WriteLine("if you would like to remove a friend enter the numeric position they are in");
                int x = Int32.Parse(Console.ReadLine());
                group.RemoveAt(x);
                break;
            case 4:
                Person rando = group[rand.Next(group.Count())];
                Console.WriteLine(rando.SSN);
                break;
            //phone num with seperator
            case 5:
                Person randy = group[rand.Next(group.Count())];
                Console.WriteLine(randy.Phone);
                break;
            case 0:
                Console.WriteLine("good riddance");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Get Good.");
                break;
        }
    }
}