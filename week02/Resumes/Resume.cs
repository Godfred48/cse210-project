using System;
public class Resume
{
    public string _name = "";

    public List<Job> jobs = new List<Job>();//we declare a list and fix jos in it.

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");
        foreach (Job job in jobs)
        {
            job.DisplayJobDetail();
        }
    }
}

