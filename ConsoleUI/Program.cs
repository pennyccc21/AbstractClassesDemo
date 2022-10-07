using Bogus.DataSets;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();
            var focus = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = 2013, };
            Vehicle motorcycle = new Motorcycle() { HasTrunk = false, Make = "Harley Davis", Model = "Black", Year = 1999, };

            Vehicle sedan = new Car() { HasTrunk = true, Make = "Jeep", Model = "Grey", Year = 2009, };
            Vehicle sport = new Car() { HasTrunk = false, Make = "Lambo", Model = "Green", Year = 2020, };



            vehicles.Add(focus);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(sport);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make {veh.Make} Model {veh.Model} Year {veh.Year}");
                veh.DriveAbstract();

            }

        }

    }
}