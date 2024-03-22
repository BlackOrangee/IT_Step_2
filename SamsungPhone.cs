using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class SamsungPhone : IPhone
    {
        public string Name { get; }

        public string Model { get; }

        public SamsungPhone(string name, string model)
        {
            Name = name;
            Model = model;
        }
    }
}
