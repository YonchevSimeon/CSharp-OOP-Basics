using System.Collections.Generic;
using System.Linq;

public class Doctor
{
    private string firstName;
    private string lastName;
    private List<string> patients;

    public string FirstName
    {
        get { return this.firstName; }
        private set { this.firstName = value; }
    }

    public string LastName
    {
        get { return this.lastName; }
        private set { this.lastName = value; }
    }

    public List<string> Patients
    {
        get { return this.patients; }
        private set { this.patients = value; }
    }

    public Doctor(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.patients = new List<string>();
    }

    public void AddPatient(string patientName)
    {
        this.patients.Add(patientName);
    }

    public void PrintPatiens()
    {
        foreach (string patient in this.patients.OrderBy(p => p))
        {
            System.Console.WriteLine(patient);
        }
    }
}
