using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{


    //*************BONUS X 2*************//

    //Create a CarLot class
    //It should have at least one property: a List of cars
    //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
    //At the end iterate through the list printing each of car's Year, Make, and Model to the console
    //internal class Carlot
internal class Carlot
{

//Inside the CarLot class from the previous exercise, create a static field called numberOfCars.
//Have this number only increment when in our program we create a new Car.
//From there, use the 3 cars in the Main() (from the previous exercise) and then each time
//you create a car do a Console.WriteLine() printing the current number of cars in the car lot.

//Inside the CarLot class from the previous exercise, create a static field called numberOfCars.
public Carlot()
{
}
//public List<Car> mycarlot = new List<Car>();
//public List<Car> mycarlot = new List<Car>();
//Have this number only increment when in our program we create a new Car.
public static int numberOfCars = 0;
public List<Car> Listofcars = new List<Car>();

}
}

