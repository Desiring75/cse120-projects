using System;

class Program
{
    static void Main(string[] args)
    {   
        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        PromptUserBirthYear(out int userBirthYear);
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber, userBirthYear);
    }

    //Creating simple functions
    //Displays the message, "Welcome to the program!"
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    //Asks for and returns the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    //Asks for and retuns the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string x = Console.ReadLine();
        int userNumber = int.Parse(x);
        return userNumber;
    }

    //Accepts "out" integer parametere and promts the user for the year they were born
    static void PromptUserBirthYear(out int userBirthYear)
    {
        Console.Write("Please enter the year you were born: ");
        string x = Console.ReadLine();
        userBirthYear = int.Parse(x);
    }

    //Accepts an integer as a parameter and returns that numer squared
    static int SquareNumber(int number)
    {
        int squareNumber = number * number;
        return squareNumber;
    }

    //Accepts the user's name, the squared number, and the user's birth year.
    static void DisplayResult (string userName, int squareNumber, int userBirthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");

        int age = 2026 - userBirthYear;
        Console.WriteLine($"{userName}, you will turn {age} this year.");
    }

}   //<--- Don't add any functions past this point
