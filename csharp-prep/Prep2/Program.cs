using System;

class Program
{
    static void Main(string[] args)
    {
        //Recreating CSE 110 using conditions
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        string letter;
        int x;
        string letterSign;

        //Series of If and Else statements to determine Grade Letter
        if (gradeNumber >= 90)
        {
            //Console.WriteLine("You got an A.");
            letter = "A";
        }

        else if (gradeNumber >= 80)
        {
            //Console.WriteLine("You got a B.");
            letter = "B";
        }

        else if (gradeNumber >= 70)
        {
            //Console.WriteLine("You got a C.");
            letter = "C";
        }

        else if (gradeNumber >= 60)
        {
            //Console.WriteLine("You got a D.");
            letter = "D";
        }
        else
        {
            //Console.WriteLine("You got an F");
            letter = "F";
        }

        //Determine if Letter is "+" or "-"
        x = gradeNumber % 10;

        if (x >= 7)
        {
            letterSign = "+";
        }

        else if (x < 3)
        {
            letterSign = "-";
        }

        else
        {
            letterSign = "";
        }

        //Get rid of A+, F+, and F-
        if (letter == "A" && letterSign == "+" || letter == "F")
        {
            letterSign = "";
        }
        
        Console.WriteLine($"You got a/an {letter}{letterSign}");

        //Determine if user passed or not
        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }

        else
        {
            Console.WriteLine("Unfortunately, you didn't pass. But you got it next time!");
        }
    }
}