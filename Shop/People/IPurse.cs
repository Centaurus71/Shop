﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    interface IPurse
    {
        int Sum { get; set; }
        void AddMoney(int sum);
        int DecMoney(int sum);
    }
}
