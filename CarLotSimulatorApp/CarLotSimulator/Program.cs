using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var carLot = new CarLot();
            carLot.CarList = new List<Car>();

            var car1 = new Car();
            car1.Year = 2018;
            car1.Make = "toyota";
            car1.Model = "Camry";
            car1.EngineNoise = "rrrrrr";
            car1.HonkNoise = "honk!";
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            carLot.CarList.Add(car1); //adding car1 to the carList
            Console.WriteLine($"Number of cars created is {CarLot.NumberOfCars}");

            var car2 = new Car() { Year = 2019, Make = "Mazda", Model = "Axela", EngineNoise = "ttttt", HonkNoise = "honk! honk!"};
            Console.WriteLine($"Number of cars created is {CarLot.NumberOfCars}");
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            carLot.CarList.Add(car2); //adding car2 to the carList


            var car3 = new Car()
            {
                Year = 2020,
                Make = "Subaru",
                Model = "legacy",
                EngineNoise = "stt stt stt",
                HonkNoise = "honk! honk! honk!"
            };
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);
            carLot.CarList.Add(car3); //adding car3 to the carList
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine($"Number of cars created is {CarLot.NumberOfCars}");
            Console.WriteLine();
            Console.WriteLine("-------------Car details-------------");
            foreach(var car in carLot.CarList)
            {
                Console.WriteLine($"Year:{car.Year} Make:{car.Make} Model: {car.Model}");

            }
        }
    }
}
