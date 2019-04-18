using System;
using System.Collections.Generic;
using System.Linq;

class RawData
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());
        List<Car> cars = GetCars(lines);
        string command = Console.ReadLine();
        PrintCars(cars, command);
    }

    private static void PrintCars(List<Car> cars, string command)
    {
        switch (command)
        {
            case "fragile": PrintFragile(cars); break;
            case "flamable": PrintFlamable(cars); break;
            default: break;
        }
    }

    private static void PrintFlamable(List<Car> cars)
    {
        List<string> flamableCars = cars
            .Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250)
            .Select(c => c.Model)
            .ToList();
        Console.WriteLine(string.Join(Environment.NewLine, flamableCars));
    }

    private static void PrintFragile(List<Car> cars)
    {
        List<string> fragileCars = cars
            .Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(t => t.TirePressure < 1))
            .Select(c => c.Model)
            .ToList();
        Console.WriteLine(string.Join(Environment.NewLine, fragileCars));
    }

    private static List<Car> GetCars(int lines)
    {
        List<Car> cars = new List<Car>();
        for (int i = 0; i < lines; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string model = parameters[0];

            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
            Engine engine = new Engine(engineSpeed, enginePower);

            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];
            Cargo cargo = new Cargo(cargoWeight, cargoType);

            Tire[] tires = new Tire[4];
            int tireIndex = 0;

            for (int index = 5; index < parameters.Length; index += 2)
            {
                double currTirePressure = double.Parse(parameters[index]);
                int currTireAge = int.Parse(parameters[index + 1]);

                tires[tireIndex++] = new Tire(currTirePressure, currTireAge);
            }

            Car car = new Car(model, engine, cargo, tires);
            cars.Add(car);
        }
        return cars;
    }
}

