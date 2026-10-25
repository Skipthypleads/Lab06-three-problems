


/*
* Name: Nathan Akins
* Course: CSCI 1250, Section 002
* Assignment: Lab 06, Three Short Problems
* Date: October 25, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/



using System.Runtime.CompilerServices;

int choice = 0;
Random rng = new Random(4000);

do
{
        choice = 0;
        System.Console.WriteLine("");
System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All three");
System.Console.WriteLine("5. Quit");

System.Console.WriteLine("");

System.Console.WriteLine("Pick an option 1-5.");

System.Console.WriteLine("");

choice = Convert.ToInt32(Console.ReadLine());
while (choice > 5 || choice < 1)
    {
        System.Console.WriteLine("You entered an invalid choice!");
        System.Console.WriteLine("Pick an option 1-5.");
        choice = Convert.ToInt32(Console.ReadLine());
    }


if (choice == 1 || choice == 4)
{
    // Exercise 1 - GRADE CHECKER
    System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
    int score;
    System.Console.WriteLine("Score");
    score = Convert.ToInt32(Console.ReadLine());

    while (score > 100 || score < 0)
    {
        System.Console.WriteLine("That grade is excessive");
        System.Console.WriteLine("Please enter a valid grade between 0 and 100");
        score = Convert.ToInt32(Console.ReadLine());
    }

    if (score >= 90)
    {
        System.Console.WriteLine($"{score} earns an A.");
    }
    else if (score >= 80 && score < 90)
    {
        System.Console.WriteLine($"{score} earns a B.");
    }
    else if (score >= 70 && score < 80)
    {
        System.Console.WriteLine($"{score} earns a C.");
    }
    else if (score >= 60 && score < 70)
    {
        System.Console.WriteLine($"{score} earns a D.");
    }
    else
    {
        System.Console.WriteLine($"{score} earns an F.");
    }
}

if (choice == 2 || choice == 4)
{

    // Exercise 2- THE DICE TABLE
System.Console.WriteLine("=== Exercise 2: The Dice Table ===");
string roll = "y";
int Iterations = 0;
int WinCase = 0;
    do
        {
            int roll1 = rng.Next(1,7);
            int roll2 = rng.Next(1,7);
            int rollTotal = roll1 + roll2;
            Iterations++;
            System.Console.Write($"Roll {Iterations}: {roll1} and {roll2}, total {rollTotal}.");

            if (roll1 == roll2 && roll1 != 1)
            {
                System.Console.Write(" Doubles!");
            }
            else if (roll1 == roll2 && roll1 == 1)
            {
               System.Console.Write(" Snake Eyes!");
            }
            else if (rollTotal == 7)
            {
                System.Console.Write(" A Winner!");
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("Roll Again? (y/n)");
            roll = Console.ReadLine().ToLower();
              while (roll != "y" && roll != "n")
            {
                System.Console.WriteLine("Roll Again? (y/n)");
                roll = Console.ReadLine().ToLower();
            }

            
            if (roll1 + roll2 == 7)
            {
                WinCase++;
            }
        } while (roll == "y");
        

        
    System.Console.WriteLine($"You rolled {Iterations} times and won {WinCase}");
    System.Console.WriteLine("");
        
 

}


if (choice == 3 || choice == 4)
{
 
// Exercise 3 SCORE REPORT
System.Console.WriteLine("=== Exercise 3: The Score Report ===");
int[] scores = new int[5];
for (int i = 0; i < scores.Length; i++) 
        {
            System.Console.Write($"Score {i + 1}: ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }

int total= 0;
int highest= scores[0];
int oversix0= 0;
                    
foreach (int score in scores)
        {
        total = total + score;
        if (score >= 60)
            {
                oversix0 = oversix0 + 1;
            }
        if (score > highest)
            {
                highest = score;
            }  
        }
        System.Console.WriteLine($"Scores entered: {scores.Length}");
        System.Console.WriteLine($"Total: {total}");
        System.Console.WriteLine($"Average: {Convert.ToDouble(total)/scores.Length:F1}");
        System.Console.WriteLine($"Highest: {highest}");
        System.Console.WriteLine($"Passing: {oversix0} of {scores.Length}");


}


} while (choice != 5);


Console.WriteLine("Goodbye.");