using System;

namespace DemoSteve
{
    class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public void Drive()
        { 
        }
    }

    class Person
    {
        public Car[] Cars { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Nitin is a Person (object of a Class Person)
            //Nitin can have two cars
            //Each car has two properties - year and make
            //Each car has one method Drive

            Car car1 = CreateCar(2001, "Honda");
            Car car2 = CreateCar(2010, "Mazda");

            //Person Nitin has two cars
            Person nitin = new Person();
            nitin.Cars = new Car[2] { car1, car2 };
        }

        /// <summary>
        /// Method/Function to create a Car(object of class Car)
        /// </summary>
        /// <param name="year"></param>
        /// <param name="make"></param>
        /// <returns></returns>
        static Car CreateCar(int year, string make)
        {
            Car car = new Car();
            car.Year = year;
            car.Make = make;

            return car;
        }
    }
}
