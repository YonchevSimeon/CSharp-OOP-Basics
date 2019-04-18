namespace Vehicles
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] carArgs = Console.ReadLine().Split();
            string[] truckArgs = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]));
            Vehicle truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]));

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int curr = 0; curr < numberOfCommands; curr++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string command = inputArgs[0];
                string vehicle = inputArgs[1];
                double commandArg = double.Parse(inputArgs[2]);

                switch (command)
                {
                    case "Drive":
                        try
                        {
                            if(vehicle == "Car")
                            {
                                car.Drive(commandArg);
                                Console.WriteLine($"Car travelled {commandArg} km");
                            }
                            else if(vehicle == "Truck")
                            {
                                truck.Drive(commandArg);
                                Console.WriteLine($"Truck travelled {commandArg} km");
                            }
                        }
                        catch(ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;
                    case "Refuel":
                        if(vehicle == "Car")
                        {
                            car.Refuel(commandArg);
                        }
                        else if(vehicle == "Truck")
                        {
                            truck.Refuel(commandArg);
                        }
                        break;
                    default: break;
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
