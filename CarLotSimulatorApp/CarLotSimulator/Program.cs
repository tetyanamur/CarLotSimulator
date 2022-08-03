using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Hyundai = new Car();
            Hyundai.Year = 2017;
            Hyundai.Make = "Hyundai";
            Hyundai.Model = "Elantra";
            Hyundai.EngineNoise = "Meep";
            Hyundai.HonkNoise = "Bzhhh";
            Hyundai.IsDriveable = true;

            //TODO
            var Nissan = new Car
            { Year = 2018,
            Make = "Nissan",
            Model = "Elantra",
            EngineNoise = "Broom",
            HonkNoise = "Brrr",
            IsDriveable = true
            };
            var Lexus = new Car(2019, "Lexus", "Eskridge", "Room", "Bleep", true);

            Hyundai.MakeEngineNoise("Beep");
            Hyundai.MakeHonkNoise("Bzhhh");
            Nissan.MakeEngineNoise("Broom");
            Nissan.MakeHonkNoise("Brr");
            Lexus.MakeEngineNoise("Room");
            Lexus.MakeHonkNoise("Bleep");


            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()


            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car


            //*************BONUS X 2*************//


            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            //bonus:
            //var carList = new List<Car>() { myCar, Lexus, Nissan };

            // foreach (var vechile in carList)
            // {
            // Console.WriteLine($"{vechile.Year} {vechile.Make} {vechile.Model} {vechile.EngineNoise} {vechile.HonkNoise} {vechile.IsDriveable}");
            // }
        }
    }
    }
