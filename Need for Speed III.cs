using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string carInput = Console.ReadLine().ToString();
                char[] separate = { '|' };
                string[] carArr = carInput.Split(separate);
                string car = carArr[0].ToString();
                int mileage = int.Parse(carArr[1]);
                int fuel = int.Parse(carArr[2]);
                cars.Add(car, new List<int>());
                cars[car].Add(mileage);
                cars[car].Add(fuel);

            }
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandArr = command.Split(" : ").ToArray();
                string car = commandArr[1].ToString();

                if (commandArr[0] == "Drive")
                {
                    int fuelNeededToDrive = int.Parse(commandArr[3]);
                    int distanceToDrive = int.Parse(commandArr[2]);
                    if (fuelNeededToDrive > cars[car][1])
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[car][0] += distanceToDrive;
                        cars[car][1] -= fuelNeededToDrive;
                        Console.WriteLine("{0} driven for {1} kilometers. {2} liters of fuel consumed.", car, distanceToDrive, fuelNeededToDrive);
                    }
                    if (cars[car][0] >= 100000)
                    {
                        Console.WriteLine("Time to sell the {0}!", car);
                        cars.Remove(car);
                    }
                }
                else if (commandArr[0] == "Refuel")
                {
                    int fuelForRefill = int.Parse(commandArr[2]);

                    int totalFuel = cars[car][1] + fuelForRefill;
                    if (totalFuel <= 75)
                    {
                        Console.WriteLine("{0} refueled with {1} liters", car, fuelForRefill);
                    }
                    else
                    {
                        int differenceToFuel = 75 - cars[car][1];
                        cars[car][1] += differenceToFuel;
                        Console.WriteLine("{0} refueled with {1} liters", car, differenceToFuel);
                    }

                }
                else if (commandArr[0] == "Revert")
                {
                    int kilometers = int.Parse(commandArr[2]);
                    cars[car][0] -= kilometers;
                    Console.WriteLine("{0} mileage decreased by {1} kilometers", car, kilometers);
                    if (cars[car][0] <= 10000)
                    {
                        cars[car][0] = 10000;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var item in cars.OrderByDescending(car => car.Value[0]).OrderBy(car => car.Key))
            {
                Console.WriteLine("{0} -> Mileage: {1} kms, Fuel in the tank: {2} lt.", item.Key, item.Value[0], item.Value[1]);

            }
        }
    }
}
