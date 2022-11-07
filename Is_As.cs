using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Concepts
{
    class aaa
    {

    }
    class bbb
    {

    }
    class ccc : aaa
    {
        public void RunCcc()
        {

        }
    }
    internal class Is_As
    {
        public void Run()
        {
            aaa a=new aaa();
            bbb b = new bbb();
            ccc c =new ccc();
            Operate(c);
        }
        public void Operate(object o)
        {
            bool test = o is aaa;
            test=o is bbb;
            test=o is ccc;
            test = o is object;
            test= o is System.IO.FileStream;
            if (o is ccc)
            {
                //reference type
                ccc c = o as ccc;
                //equal to:
                c = (ccc)o;
                //run method
                c.RunCcc();
            }

        }
    }
}
