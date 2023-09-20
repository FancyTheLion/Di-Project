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
        private IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void DriveTo(string destination)
        {
            _engine.StartEngine();
            Console.WriteLine($"Автомобиль двигается в {destination}");
            _engine.StopEngine();
        }
    }
}
