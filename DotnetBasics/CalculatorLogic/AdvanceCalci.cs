﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLogic
{
    public class AdvanceCalci:simpleCalci  //AdvanceCalci is inherites simpleCalci
    {
        public double SquareRoot(double no)
        {
            return Math.Sqrt(no);
        }
    }
}