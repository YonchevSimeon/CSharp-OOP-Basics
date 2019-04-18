using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        int numberOfCars = int.Parse(Console.ReadLine());
        for (int cur = 0; cur < numberOfCars; cur++)
        {
            string[] inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string carModel = inputTokens[0];
            double fuelAmount = double.Parse(inputTokens[1]);
            double fuelConsumptionPerKilometer = double.Parse(inputTokens[2]);
            cars.Add(new Car(carModel, fuelAmount, fuelConsumptionPerKilometer));
        }
        string input;
        while((input = Console.ReadLine()) != "End")
        {
            string[] inputTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string carModel = inputTokens[1];
            int kilometers = int.Parse(inputTokens[2]);
            cars.First(c => c.CarModel == carModel).DriveTheCarWith(kilometers);
        }
        cars.ForEach(c => Console.WriteLine(c));
    }
}
