﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.interfaces;

namespace AbstractFactoryAutomovil.mundo.clases
{
    class MotorMazda : IMotor
    {
        public string darNombre()
        {
            return "Motor Mazda";
        }
    }
}
