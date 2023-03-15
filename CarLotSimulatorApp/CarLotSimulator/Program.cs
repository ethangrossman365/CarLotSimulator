using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var lot = new CarLot();

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            var ethansCar = new Car();
            ethansCar.Make = "Ford";
            ethansCar.Model = "Focus";
            ethansCar.Year = 2013;
            ethansCar.EngineNoise = "vroom";
            ethansCar.HonkNoise = "beep";
            ethansCar.IsDriveable = true;

            lot.Cars.Add(ethansCar);



            var jacksCar = new Car()
            {
                Year = 2020,
                Make = "Jeep",
                Model = "Wrangler",
                EngineNoise = "Gas",
                HonkNoise = "Loud",
                IsDriveable = true,
            };

            lot.Cars.Add(jacksCar);

            var juddsCar = new Car(2022, "Jeep", "Liberty", "Gas", "Loud", true);
            lot.Cars.Add(juddsCar);

            ethansCar.MakeEngineNoise(ethansCar.EngineNoise);
            jacksCar.MakeEngineNoise(jacksCar.EngineNoise);
            juddsCar.MakeEngineNoise(juddsCar.EngineNoise);

            ethansCar.MakeHonkNoise(ethansCar.HonkNoise);
            jacksCar.MakeHonkNoise(jacksCar.HonkNoise);
            juddsCar.MakeHonkNoise(juddsCar.HonkNoise);
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model {car.Model}");


            }
        }
    }
}
