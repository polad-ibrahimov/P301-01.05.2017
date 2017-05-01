using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myelements
{
    class P301
    {
        public int sum(int a,int b)
        {
            return a + b;
        }

        public static implicit operator int(P301 v)
        {
            throw new NotImplementedException();
        }
    }

    class Kamran
    {
        public int bolme(int a,int b)
        {
            return a/ b;
        }
    }
}
