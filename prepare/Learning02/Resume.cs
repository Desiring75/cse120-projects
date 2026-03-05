using System;

//Creating the Resume class
public class Resume
{
    //Member variables
    public string _name;
    public List<Job> _jobs = new List<Job>();

    //Methods
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job j in _jobs)
        {
            j.DisplayJobDetails();
        }
    }
}