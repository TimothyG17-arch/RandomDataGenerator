using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Would you like to create a imaginary friend and/or friends? Press 1 to create your first friend");
Console.WriteLine("Type 1. to view your friends.");
Console.WriteLine("Type 2. to make a random imaginary last name. ");
Console.WriteLine("Type 3. to display a imaginary friends Social Security Information.");
Console.WriteLine("Type 4. to display an imaginary friends phone number and seperate it as you please.");
Console.WriteLine("If you wish to exit type 0.");

//switch to the menu output above
string ans = Console.ReadLine();
do
{
    switch (ans)
    {
        //Friend Viewer
        case "1":

            break;
        //Last name from enum
        case "2":

            break;
        //SSN
        case "3":

            break;
        //phone num with seperator
        case "4":
            Console.WriteLine("What seperator would you like to use?");
            string sep = Console.ReadLine();
            
            break;
    }
} while (ans != "0"); 