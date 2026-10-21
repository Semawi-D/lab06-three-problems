using System.ComponentModel;
using System.Formats.Asn1;
using System.Xml.Serialization;
double choice = 0;
Random rng = new Random(4000);

//Menu
do
{
choice = 0;
Console.WriteLine("");
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All three");
Console.WriteLine("5. Quit");
Console.Write("Choose 1 through 5: ");
choice = Convert.ToDouble(Console.ReadLine() ?? "0");
while( choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5)
    {
        Console.WriteLine("");
        Console.WriteLine("Choose a number from 1 to 5.");
        Console.Write("Choose 1 through 5: ");
        choice = Convert.ToDouble(Console.ReadLine() ?? "0");
    }
choice = Convert.ToInt32(choice);

//Ex 1
 if (choice == 1 || choice == 4)
{
  Console.WriteLine("");
  Console.Write("Score: ");
  double score = Convert.ToDouble(Console.ReadLine() ?? "0");
  while(score < 0 || score > 100)
    {
        Console.WriteLine("");
        Console.WriteLine("A score must be between 0 and 100.");
        Console.Write("Score: ");
        score = Convert.ToDouble(Console.ReadLine() ?? "0");
    }
        if(score >= 90)
        {
            Console.WriteLine("");
            Console.WriteLine($"{score} earns an A.");
        }
        else if(score >= 80 && score < 90 )
        {
            Console.WriteLine("");
            Console.WriteLine($"{score} earns a B.");
        }
        else if(score >= 70 && score < 80 )
        {
            Console.WriteLine("");
            Console.WriteLine($"{score} earns a C.");
        }
        else if(score >= 60 && score < 70 )
        {
            Console.WriteLine("");
            Console.WriteLine($"{score} earns a D.");
        }
        else if(score < 60)
        {
            Console.WriteLine("");
            Console.WriteLine($"{score} earns an F.");
        } 
}

//Ex2
if (choice == 2 || choice == 4)
{
    string answer;
    string message;
    int i = 1;
    int wins = 0;
    do
    { 
      int value1 = rng.Next(1,7);
      int value2 = rng.Next(1,7);
      if (value1 == 1 && value2 == 1)
            {
                message = "Snake eyes.";
            }
      else if (value1 == value2 && value1 != 1 && value2 != 1)
            {
                message = "Doubles!";
            }
      else if(value1 + value2 == 7 || value1 + value2 == 11)
            {
                message = "A winner.";
                ++wins;
            }
            else
            {
                message = "";
            }
      Console.WriteLine("");
      Console.WriteLine($"Role {i}: {value1} and {value2}, total {value1 + value2}. {message}");
      Console.Write("Roll again? (y/n): ");
      answer = (Console.ReadLine() ?? "n").Trim().ToLower();
      ++i;
    } while(answer.Equals("y"));
    Console.WriteLine($"You rolled {i - 1} times and won {wins}.");
}
if (choice == 3 || choice == 4)
{
    //3
}
} while (choice != 5);

Console.WriteLine("");
Console.WriteLine("Goodbye.");




