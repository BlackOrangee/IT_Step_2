using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class LG : IAbstractFactory
    {
        public INoteboock CreateNoteboock()
        {
            return new LGNoteboock("Noteboock", "LG");
        }

        public IPhone CreatePhone()
        {
            return new LGPhone("Phone", "LG");
        }
    }
}
