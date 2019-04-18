using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Doctor> doctors = new List<Doctor>();
        List<Department> departments = new List<Department>();


        string command;
        while ((command = Console.ReadLine()) != "Output")
        {
            string[] commandArgs = command.Split();
            var departmentName = commandArgs[0];
            var doctorFirstName = commandArgs[1];
            var doctorLastName = commandArgs[2];
            var patientName = commandArgs[3];

            Department department = departments.FirstOrDefault(d => d.Name == departmentName);

            if (department == null)
            {
                department = new Department(departmentName);
                department.GetNewRoom();
                departments.Add(department);
            }

            if (department.RoomNumber == 19 && department.Rooms[19].Count == 3)
            {
                continue;
            }

            if (department.Rooms[department.RoomNumber].Count == 3)
            {
                department.IncreaseRoomNumber();
                department.GetNewRoom();
            }

            department.AddPatient(patientName);

            Doctor doctor = doctors.FirstOrDefault(d => d.FirstName == doctorFirstName && d.LastName == doctorLastName);

            if (doctor == null)
            {
                doctor = new Doctor(doctorFirstName, doctorLastName);
                doctors.Add(doctor);
            }

            doctor.AddPatient(patientName);

        }

        while ((command = Console.ReadLine()) != "End")
        {
            string[] commandArgs = command.Split();

            if (commandArgs.Length == 1)
            {
                Department department = departments.Find(d => d.Name == commandArgs[0]);
                department.PrintAllPatients();
            }
            else if (int.TryParse(commandArgs[1], out int room))
            {
                Department department = departments.Find(d => d.Name == commandArgs[0]);
                department.PrintRoom(room);
            }
            else
            {
                Doctor doctor = doctors.Find(d => d.FirstName == commandArgs[0] && d.LastName == commandArgs[1]);
                doctor.PrintPatiens();
            }

        }
    }
}

