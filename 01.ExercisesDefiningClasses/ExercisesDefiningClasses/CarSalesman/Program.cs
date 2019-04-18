using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        List<Engine> engines = new List<Engine>();
        int numberOfEngines = int.Parse(Console.ReadLine());
        for (int curr = 0; curr < numberOfEngines; curr++)
        {
            string[] inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = inputTokens[0];
            string power = inputTokens[1];
            Engine engine = new Engine(model, power);
            if(inputTokens.Length == 3)
            {
                int n;
                bool isNumber = int.TryParse(inputTokens[2], out n);
                if (isNumber)
                {
                    engine.Displacement = inputTokens[2];
                }
                else
                {
                    engine.Efficieny = inputTokens[2];
                }
            }
            else if(inputTokens.Length == 4)
            {
                engine.Displacement = inputTokens[2];
                engine.Efficieny = inputTokens[3];
            }
            engines.Add(engine);
        }
        int numberOfCars = int.Parse(Console.ReadLine());
        for (int curr = 0; curr < numberOfCars; curr++)
        {
            string[] inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = inputTokens[0];
            Engine wantedEngineModel = engines.Find(e => e.Model == inputTokens[1]);
            Car car = new Car(model, wantedEngineModel);
            if (inputTokens.Length == 3)
            {
                int n;
                bool isNumber = int.TryParse(inputTokens[2], out n);
                if (isNumber)
                {
                    car.Weight = inputTokens[2];
                }
                else
                {
                    car.Color = inputTokens[2];
                }
            }
            else if (inputTokens.Length == 4)
            {
                car.Weight = inputTokens[2];
                car.Color = inputTokens[3];
            }
            cars.Add(car);
        }

        cars.ForEach(c => Console.WriteLine(c));
    }
}
