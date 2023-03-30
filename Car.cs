using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;


namespace Practical_Lesson_4
{
    internal class Car
    {
        private string Stamp;
        private int NumberOfCylinders;
        private int LoadCapacity;
        public Car(string stamp, int numberOfCylinders, int power)
        {
            if (Stamp == null)
                throw new NullReferenceException("Stamp");
            Stamp = stamp;
            NumberOfCylinders = numberOfCylinders;
            LoadCapacity = power;
        }
        void Read()
        {
            Console.WriteLine("Укажите торговую марку:");
            Stamp = Convert.ToString(Console.Read());
            Console.WriteLine("Укажите количество цилиндров:");
            NumberOfCylinders = Convert.ToInt32(Console.Read());
            Console.WriteLine("Укажите мощность:");
            LoadCapacity = Convert.ToInt32(Console.Read());
            Console.WriteLine("");
        }
        void Display()
        {
            Console.WriteLine("Automobile");
            Console.WriteLine($"Stamp:{Stamp}");
            Console.WriteLine($"NumberOfCylinders:{NumberOfCylinders}");
            Console.WriteLine($"Power:{LoadCapacity}");
        }
        public int ReassignmentPower(Car car)
        {
            if (car == null)
                throw new NullReferenceException("car");
            Console.WriteLine($"Мощность автомобиля: {car.LoadCapacity}");
            int NewPower = Convert.ToInt32(Console.ReadLine());
            return car.LoadCapacity = NewPower;
            Console.WriteLine($"Мощность автомобиля: {car.LoadCapacity}");
        }
    }
}
