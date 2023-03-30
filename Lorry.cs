using Practical_Lesson_4;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lesson__4
{
    internal class Lorry: Car
    {
        private int LoadCapacity;
        public Lorry(string stamp, int numberOfCylinders, int power, int loadCapacity) :
           base(stamp, numberOfCylinders, power)
        {
            if (stamp == null)
                throw new NullReferenceException("stamp");
            LoadCapacity = loadCapacity;
        }
        void Read()
        {
            Console.WriteLine("Укажите грузоподъёмность:");
            LoadCapacity = Convert.ToInt32(Console.Read());
            Console.WriteLine("");
        }
        void Display()
        {
            Console.WriteLine("Lorry");
            Console.WriteLine($"LoadCapacity:{LoadCapacity}");
        }
        public int ReassignmentLoadCapacity(Lorry lorry)
        {
            if (lorry == null)
                throw new NullReferenceException("lorry");
            Console.WriteLine($"Грузоподъёмность: {lorry.LoadCapacity}");
            int NewLoadCapacity = Convert.ToInt32(Console.ReadLine());
            return lorry.LoadCapacity = NewLoadCapacity;
            Console.WriteLine($"Грузоподъёмность: {lorry.LoadCapacity}");
        }
    }
}
