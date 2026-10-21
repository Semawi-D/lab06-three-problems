using System.ComponentModel;
using System.Xml.Serialization;
double choice = 0;

//Menu
do
{
choice = 0;
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All three");
Console.WriteLine("5. Quit");
Console.WriteLine("Choose 1 through 5: ");
choice = Convert.ToDouble(Console.ReadLine() ?? "0");
while( choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5)
    {
        Console.WriteLine("Choose a number from 1 to 5.");
        choice = Convert.ToDouble(Console.ReadLine() ?? "0");
    }
choice = Convert.ToInt32(choice);
 if (choice == 1 || choice == 4)
{
  //1
}
if (choice == 2 || choice == 4)
{
    //2
}
if (choice == 3 || choice == 4)
{
    //3
}
} while (choice != 5);

Console.WriteLine("Goodbye.");




