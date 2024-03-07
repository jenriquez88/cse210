using System;

public class Resume //Created Resume class
{
    public string _name; //Created member variable

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");


        foreach (Job job in _jobs)
        {

            job.Display();
        }
    }
}