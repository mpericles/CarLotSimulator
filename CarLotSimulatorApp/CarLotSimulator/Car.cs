using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CarLotSimulator
{
  
    internal class Car
    {
        //Dot Notation Syntax/Method
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        // car constructor
        public Car()
        {
        }

        //Custom Constructor Syntax
        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isdriveable)
            {
            Make= make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isdriveable;
        }

        //Object Initializer Syntax - was working before
        //public Car(string v1, string v2, int v3, string v4, string v5, bool v6)
        //{
          //  Make = v1;
          //  Model = v2;
          //  Year = v3;
          //  EngineNoise = v4;
          // HonkNoise = v5;
          //  IsDriveable = v6;
        //}
       

        //Create Methods for the car
        public void MakeEngineNoise()
        {
            Console.WriteLine("Car Noise Details - EngineNoise");
            Console.WriteLine($" My Engine Noise is {EngineNoise}");
        }

        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine("Car Noise Details - HonkNoise");
            //Console.WriteLine($" My honk noise is {HonkNoise}"); - Different way to do it
            Console.WriteLine($" My honk Noise is {noise}"); 
        }


        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property


    }


}

