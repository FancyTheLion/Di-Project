using DI_Car.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Car.Concrete
{
    internal class Car : ICar
    {
        public void DriveTo(string destination)
        {
            Console.WriteLine($"Автомобиль двигается в {destination}");
        }
    }
}
