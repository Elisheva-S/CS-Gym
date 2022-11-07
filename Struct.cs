using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Concepts
{
    // located in heap
    internal class Struct
    {
        public void Run()
        {
            B b;
            b.c = 8;
            b.l = new Label();
        }
    }
    // located in stack
    public struct B
    {
        public int c;
    //in struct we can't init property with new because it's located in the heap;
    //public Label l=new Label();
        public Label l;
}
}
