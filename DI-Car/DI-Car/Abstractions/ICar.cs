using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Car.Abstractions
{
    internal interface ICar
    {
        /// <summary>
        /// Движение куда-либо
        /// </summary>
        /// <param name="destination">Место назначения</param>
        void DriveTo(string destination);
    }
}
