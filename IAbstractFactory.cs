﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal interface IAbstractFactory
    {
        IPhone CreatePhone();

        INoteboock CreateNoteboock();
    }
}
