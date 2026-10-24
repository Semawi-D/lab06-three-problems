/*
* Name: Semawi Deneke
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 24, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/



double choice = 0;
Random rng = new Random(4000);

// I used the do while loop because we need to run the menu once to know what the user wants/inputs, then we will keep the program running until the user wants to quit.
do
{
//The Menu
Console.WriteLine("");
Console.WriteLine("=== CSCI 1250 Lab 06 ===");
choice = 0;
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All three");
Console.WriteLine("5. Quit");
Console.Write("Choose 1 through 5: ");
choice = Convert.ToDouble(Console.ReadLine() ?? "0");
//I used the while loop in order to ask the user for the right input until they enter the accepted inputs.
while( choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5)
    {

        Console.WriteLine("Choose a number from 1 to 5.");
        Console.Write("Choose 1 through 5: ");
        choice = Convert.ToDouble(Console.ReadLine() ?? "0");
    }
choice = Convert.ToInt32(choice);

//Exercise 1: The Grade Checker
 if (choice == 1 || choice == 4)
{
  Console.WriteLine("");
  Console.WriteLine("=== Exercise 1: The Grade Checker ===");
  Console.Write("Score: ");
  double score = Convert.ToDouble(Console.ReadLine() ?? "0");
//I used the while loop in order to ask the user for the right input until they enter the accepted inputs.
  while(score < 0 || score > 100)
    {
        Console.WriteLine("A score must be between 0 and 100.");
        Console.Write("Score: ");
        score = Convert.ToDouble(Console.ReadLine() ?? "0");
    }
        if(score >= 90)
        {
            Console.WriteLine($"{score} earns an A.");
        }
        else if(score >= 80 && score < 90 )
        {
            Console.WriteLine($"{score} earns a B.");
        }
        else if(score >= 70 && score < 80 )
        {
            Console.WriteLine($"{score} earns a C.");
        }
        else if(score >= 60 && score < 70 )
        {
            Console.WriteLine($"{score} earns a D.");
        }
        else
        {
            Console.WriteLine($"{score} earns an F.");
        } 
}

//Exercise 2: The Dice Table
if (choice == 2 || choice == 4)
{
    Console.WriteLine("");
    Console.WriteLine("=== Exercise 2: The Dice Table ===");
    string answer;
    string message;
    int i = 1;
    int wins = 0;
//I used the do while loop because the intsructions indicate that the dice has to roll once before the user can choose to continue or not.
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
      Console.WriteLine($"Role {i}: {value1} and {value2}, total {value1 + value2}. {message}");
      Console.Write("Roll again? (y/n): ");
      answer = (Console.ReadLine() ?? "n").Trim().ToLower();
      ++i;
    } while(answer.Equals("y"));
    Console.WriteLine($"You rolled {i - 1} times and won {wins}.");
}

//Exercise 3: The Score Report
if (choice == 3 || choice == 4)
{
    Console.WriteLine("");
    Console.WriteLine("=== Exercise 3: The Score Report ===");
    int[] scores = new int[5];
// I used the for loop because the instructions indicate that the user has to enter exactly 5 scores for this excercise, and this loop is best for iterating over a fixed range.
for (int i = 0; i < 5; i++)
        {
            Console.Write($"Score {i + 1}: ");
            scores[i] = Convert.ToInt32(Console.ReadLine() ?? "0");
        }
    int total = 0;
    int highest = 0;
    int passing = 0;
// I used the foreach loop because it's best for iterating over an entire array, and listing/outputing each value in the array.
foreach(int score in scores)
        {
            total += score;
            highest = Math.Max(highest,score);
            if (score >= 60)
            {
                ++passing;
            }
        }
    double average = (double)total/scores.Length;
    average = Math.Round(average,2);
    Console.WriteLine("");
    Console.WriteLine($"Scores entered: {scores.Length}");
    Console.WriteLine($"Total: {total}");
    Console.WriteLine($"Average: {average}");
    Console.WriteLine($"Highest: {highest}");
    Console.WriteLine($"Passing: {passing} of {scores.Length}");
}
} while (choice != 5);

Console.WriteLine("");
Console.WriteLine("Goodbye.");




