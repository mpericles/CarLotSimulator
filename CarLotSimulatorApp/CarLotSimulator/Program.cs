using CarLotSimulator;
using System;
using System.Security;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //Carlot mycarlot = new();
            Carlot carlotinstance = new Carlot();


            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //car has been created in the car class file

            //Set the properties for each of the cars
            //Call each of the methods for each car
            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car


            //Dot Notation Syntax/Method with default constructor
            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Corolla";
            car1.Year = 1999;
            car1.EngineNoise = "Vroom";
            car1.HonkNoise = "hmm";
            car1.IsDriveable = true;
            car1.MakeEngineNoise();
            car1.MakeHonkNoise(car1.HonkNoise);


            //Custom Constructor Syntax/Method - it was working before
            //Car car2 = new("AlphaRomeo", "Guilietta", 1987, "shsh", "pappap", true);
            //car2.MakeEngineNoise();
            //car2.MakeHonkNoise("pappap");


            //Object Initializer Syntax/Method
            Car car3 = new() { Make = "Porsche", Model = "Cayenne", Year = 2023, EngineNoise = "hmm", HonkNoise = "Beep", IsDriveable = true };
            car3.MakeEngineNoise();
            car3.MakeHonkNoise("Beep");

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            //Carlot.mycarlot.Add(car1);
            //carlot.mycarlot.Add(car2);
            //carlot.mycarlot.Add(car3);

            carlotinstance.Listofcars.Add(car1);
            //carlotinstance.Listofcars.Add(car2);
            carlotinstance.Listofcars.Add(car3);

            //for (int i = 0; i < Carlot.mycarlot.Count; i++)
            foreach (var item in carlotinstance.Listofcars)
            //foreach (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Car details");
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Year);
                Console.WriteLine(item.EngineNoise);
                Console.WriteLine(item.HonkNoise);
                Console.WriteLine(item.IsDriveable);               
                Console.WriteLine(" ");

                //  Console.WriteLine(Carlot.mycarlot[i]);
            }

        }

    }
}

