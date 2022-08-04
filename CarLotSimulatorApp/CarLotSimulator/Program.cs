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


            CarLot lot = new CarLot();

       
            Console.WriteLine($"num of cars made: {CarLot.numberOfCars}");
           
            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model} ");
            }
        }
    }
    }
