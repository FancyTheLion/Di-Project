﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Car.Abstractions
{
    internal interface IEngine
    {

        /// <summary>
        /// Завести мотор
        /// </summary>
        void StartEngine();

        /// <summary>
        /// Заглушить мотор
        /// </summary>
        void StopEngine();
    }
}
