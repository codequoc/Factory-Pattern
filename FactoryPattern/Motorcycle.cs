﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Build()
        {
            Console.WriteLine("The Motorcycle is revving up!!!");
        }
    }
}
