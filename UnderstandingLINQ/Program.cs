using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            // LINQ query
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year > 2008
                       select car;

            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

            */
            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;

            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.VIN);
            }
            */

            // LINQ method
            /*
            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year > 2008);

            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
            */
            /*
            var orderedCars = myCars.OrderByDescending(p => p.Year);

            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.VIN);
            }
            */

            /* How to use .First and .Last
            //var firstBMW = myCars.First(p => p.Make == "BMW");
            //Console.WriteLine(firstBMW.VIN);

            var firstBMW = myCars.OrderByDescending(p => p.Year).Last(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);
            */

            /* How to use .TrueForAll
            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012)); // false
            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007)); // true
            */

            /* Compact a foreach from 4 lines of code to 1
            myCars.ForEach(p => p.StickerPrice -= 3000);  // take $3000 off the sticker price
            myCars.ForEach(p => Console.WriteLine("{0} {1} {2:C}", p.VIN, p.Make, p.StickerPrice));
            */

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
