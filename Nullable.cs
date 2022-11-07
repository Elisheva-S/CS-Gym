using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Concepts
{
    internal class Nullable
    {
        public void Val()
        {
            // a can't be equel to null
            int a;
            //a = nall;
            int? b;
            b = null;
            if(b==null)
            {

            }
            if(b.HasValue)
            {

            }
            if(b is null)
            {

            }
            // if b==null than b==6.
            //b ??= 6;         
        }
    }
}
