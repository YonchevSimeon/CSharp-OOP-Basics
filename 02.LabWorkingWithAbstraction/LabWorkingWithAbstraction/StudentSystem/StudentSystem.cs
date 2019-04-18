using System;
using System.Collections.Generic;
public class StudentSystem
{
    private Dictionary<string, Student> repository;

    public Dictionary<string, Student> Repository
    {
        get { return this.repository; }
        private set { this.repository = value; }
    }

    public StudentSystem()
    {
        this.repository = new Dictionary<string, Student>();
    }

    public void ParseCommand()
    {
        string[] args = Console.ReadLine().Split();

        string command = args[0];

        switch (command)
        {
            case "Create": Create(args); break;
            case "Show": Show(args); break;
            case "Exit": Environment.Exit(0); break;
            default:break;
        }
    }

    private void Show(string[] args)
    {
        string name = args[1];
        if (Repository.ContainsKey(name))
        {
            Student student = Repository[name];
            string view = $"{student.Name} is {student.Age} years old.";

            if (student.Grade >= 5.00)
            {
                view += " Excellent student.";
            }
            else if (student.Grade < 5.00 && student.Grade >= 3.50)
            {
                view += " Average student.";
            }
            else
            {
                view += " Very nice person.";
            }

            Console.WriteLine(view);
        }
    }

    private void Create(string[] args)
    {
        string name = args[1];
        int age = int.Parse(args[2]);
        double grade = double.Parse(args[3]);
        if (!repository.ContainsKey(name))
        {
            Student student = new Student(name, age, grade);
            Repository[name] = student;
        }
    }
}
