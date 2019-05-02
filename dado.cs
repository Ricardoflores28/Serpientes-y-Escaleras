using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serpintes_y_escaleras
{
    class dado
    {
        Random a = new Random();

        public int num_random()
        {

            int b = 0;
            b = a.Next(1, 6);
            return b;
        }

    }
}
