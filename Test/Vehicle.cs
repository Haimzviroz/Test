using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Vehicle
    {
        protected string? Model;
        private int EngineCapacity;


    }
    class Car : Vehicle
    {
        internal int NumberOfDoors;
        public void SetCar(string model, int numberOfDoors)
        {
            Model = model;
            NumberOfDoors = numberOfDoors;

        }
        public string GetCar()
        {
            //EngineCapacity is inaccessible due to its protection level
            return $"Model: {Model}, Engine Capacity: {EngineCapacity} liters, Number of Doors: {NumberOfDoors}";

        }
    }
}
