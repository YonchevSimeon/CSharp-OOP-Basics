using System;

namespace VehiclesExtention
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carArgs = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]), double.Parse(carArgs[3]));
            string[] truckArgs = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]), double.Parse(truckArgs[3]));
            string[] busArgs = Console.ReadLine().Split();
            Vehicle bus = new Bus(double.Parse(busArgs[1]), double.Parse(busArgs[2]), double.Parse(busArgs[3]));
            
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int curr = 0; curr < numberOfCommands; curr++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                string command = commandArgs[0];
                string type = commandArgs[1];
                double dependantParam = double.Parse(commandArgs[2]);

                Vehicle vehicle;
                if (type == "Car")
                    vehicle = car;
                else if (type == "Truck")
                    vehicle = truck;
                else
                    vehicle = bus;

                try
                {
                    string output = $"{vehicle.GetType().Name} travelled {dependantParam} km";
                    switch (command)
                    {
                        case "Drive":
                            vehicle.Drive(dependantParam);
                            Console.WriteLine(output);
                            break;
                        case "DriveEmpty":
                            ((Bus)vehicle).DriveEmpty(dependantParam);
                            Console.WriteLine(output);
                            break;
                        case "Refuel":
                            vehicle.Refuel(dependantParam);
                            break;
                        default:break;
                    }

                }
                catch(ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
