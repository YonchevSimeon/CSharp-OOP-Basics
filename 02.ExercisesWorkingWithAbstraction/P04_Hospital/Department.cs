using System.Collections.Generic;
using System.Linq;

public class Department
{
    private string name;
    private List<List<string>> rooms;
    private int roomNumber;
    
    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }

    public List<List<string>> Rooms
    {
        get { return this.rooms; }
        private set { this.rooms = value; }
    }

    public int RoomNumber
    {
        get { return this.roomNumber; }
        private set { this.roomNumber = value; }
    }

    public Department(string name)
    {
        this.name = name;
        this.rooms = new List<List<string>>(20);
        this.roomNumber = 0;
    }

    public void GetNewRoom()
    {
        this.rooms.Add(new List<string>());
    }

    public void IncreaseRoomNumber()
    {
        this.roomNumber++;
    }

    public void AddPatient(string patientName)
    {
        this.rooms[this.roomNumber].Add(patientName);
    }

    public void PrintAllPatients()
    {
        foreach (List<string> room in this.rooms)
        {
            foreach (string patient in room)
            {
                System.Console.WriteLine(patient);
            }
        }
    }

    public void PrintRoom(int room)
    {
        foreach (string patient in this.rooms[room - 1].OrderBy(p => p))
        {
            System.Console.WriteLine(patient);
        }
    }
}
