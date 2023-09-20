using DI_Car.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Car.Concrete
{
    internal class Engine3 : IEngine
    {
         public void StartEngine()
        {
            Console.WriteLine("Запуск двигателя 3");
        }

        public void StopEngine()
        {
            Console.WriteLine("Остановка двигателя 3");
        }
    }
}
