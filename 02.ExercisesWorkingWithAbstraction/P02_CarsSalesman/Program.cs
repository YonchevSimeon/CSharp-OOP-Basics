﻿using System;
using System.Collections.Generic;
using System.Linq;

class CarSalesman
{
    static void Main(string[] args)
    {

        int engineCount = int.Parse(Console.ReadLine());
        List<Engine> engines = GetEngines(engineCount);

        int carCount = int.Parse(Console.ReadLine());
        List<Car> cars = GetCars(carCount, engines);

        PrintCars(cars);
    }

    private static void PrintCars(List<Car> cars)
    {
        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }

    private static List<Car> GetCars(int carCount, List<Engine> engines)
    {
        List<Car> cars = new List<Car>();
        for (int i = 0; i < carCount; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = parameters[0];
            string engineModel = parameters[1];
            Engine engine = engines.FirstOrDefault(e => e.Model == engineModel);

            int weight = -1;

            if (parameters.Length == 3 && int.TryParse(parameters[2], out weight))
            {
                cars.Add(new Car(model, engine, weight));
            }
            else if (parameters.Length == 3)
            {
                string color = parameters[2];
                cars.Add(new Car(model, engine, color));
            }
            else if (parameters.Length == 4)
            {
                string color = parameters[3];
                cars.Add(new Car(model, engine, int.Parse(parameters[2]), color));
            }
            else
            {
                cars.Add(new Car(model, engine));
            }
        }
        return cars;
    }

    private static List<Engine> GetEngines(int engineCount)
    {
        List<Engine> engines = new List<Engine>();
        for (int i = 0; i < engineCount; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = parameters[0];
            int power = int.Parse(parameters[1]);

            int displacement = -1;

            if (parameters.Length == 3 && int.TryParse(parameters[2], out displacement))
            {
                engines.Add(new Engine(model, power, displacement));
            }
            else if (parameters.Length == 3)
            {
                string efficiency = parameters[2];
                engines.Add(new Engine(model, power, efficiency));
            }
            else if (parameters.Length == 4)
            {
                string efficiency = parameters[3];
                engines.Add(new Engine(model, power, int.Parse(parameters[2]), efficiency));
            }
            else
            {
                engines.Add(new Engine(model, power));
            }
        }
        return engines;
    }
}


