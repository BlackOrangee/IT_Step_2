using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Samsung : IAbstractFactory
    {
        public INoteboock CreateNoteboock()
        {
            return new SamsungNotebook("Noteboock", "Samsung");
        }

        public IPhone CreatePhone()
        {
            return new SamsungPhone("Phone", "Samsung");
        }
    }
}
