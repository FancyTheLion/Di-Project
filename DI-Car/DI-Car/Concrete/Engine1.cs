using DI_Car.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Car.Concrete
{
    internal class Engine1 : IEngine
    {
        public void StartEngine()
        {
            Console.WriteLine("Запуск двигателя 1");
        }

        public void StopEngine()
        {
            Console.WriteLine("Остановка двигателя 1");
        }
    }
}
