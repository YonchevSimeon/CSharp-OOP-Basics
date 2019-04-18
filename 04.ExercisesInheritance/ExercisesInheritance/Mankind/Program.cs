namespace Mankind
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] studentArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string studentFirstName = studentArgs[0];
                string studentLastName = studentArgs[1];
                string facultyNumber = studentArgs[2];
                Student student = new Student(studentFirstName, studentLastName, facultyNumber);
                

                string[] workerArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string workerFirstName = workerArgs[0];
                string workerLastName = workerArgs[1];
                decimal weekSalary = decimal.Parse(workerArgs[2]);
                decimal workingHours = decimal.Parse(workerArgs[3]);
                Worker worker = new Worker(workerFirstName, workerLastName, weekSalary, workingHours);

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
