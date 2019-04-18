using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        int numberOfCars = int.Parse(Console.ReadLine());
        for (int curr = 0; curr < numberOfCars; curr++)
        {
            string[] inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = inputTokens[0];
            int engineSpeed = int.Parse(inputTokens[1]);
            int enginePower = int.Parse(inputTokens[2]);
            int cargoWeight = int.Parse(inputTokens[3]);
            string cargoType = inputTokens[4];
            Tire[] tires = new Tire[4];
            int tireIndex = 0;
            for (int index = 5; index < inputTokens.Length; index += 2)
            {
                double currTirePressure = double.Parse(inputTokens[index]);
                int currTireAge = int.Parse(inputTokens[index + 1]);
                tires[tireIndex++] = new Tire(currTirePressure, currTireAge);
            }
            cars.Add(new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoWeight, cargoType), tires));
        }
        string command = Console.ReadLine();
        if(command == "fragile")
        {
            foreach(Car car in cars.Where(c => c.Cargo.Type == command && c.Tires.Any(t => t.Pressure < 1)))
            {
                Console.WriteLine(car.Model);
            }
        }
        else if(command == "flamable")
        {
            foreach (Car car in cars.Where(c => c.Cargo.Type == command && c.Engine.Power > 250))
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}

