using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var Lexus = new Car(2019, "Lexus" ,"Eskridge", "Room", "Beep" , true);
            var Hyndai = new Car(2015, "Hyndai", "Elantra", "Bzzzz", "Boom", true);
            var Nissan = new Car(2018, "Nissan", "Altima", "Broozh", "Meep",  true);
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()

            //* METHODS PT1:Lexus.MakeEngineNoise("Room");
            //           Hyndai.MakeEngineNoise("Brzz");
            //           Nissan.MakeEngineNoise("Broozh");
            //
            //PT2       Lexus.MakeHonkNoise("Beep");
            //          MakeHonkNoise("Boom");
            //          MakeHonkNoise("Meep");
           
            //The methods should take one string parameter: the respective noise property
            var carList = new List<Car>() { Lexus, Hyndai, Nissan };

                foreach (var vechile in carList)
                {
                Console.WriteLine($"{vechile.Year} {vechile.Make} {vechile.Model} {vechile.EngineNoise} {vechile.HonkNoise} {vechile.IsDriveable}");
                }

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
        }
    }
}
