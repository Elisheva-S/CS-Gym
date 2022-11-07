using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Concepts
{
    internal class Ref_Val
    {
        
        public void Run()
        {
            int a = 10;
            Change(a);// this won't change- it's by value.
            Label l = new Label();
            ChangeLabel(l);//this will change - it's by reference.
            int b = 5;
            int c;
            //when i use with out- i must put a value in this parameter.
            ChangeB(ref b, out c);//this will change- it's became by reference.
        }
        public void Change(int a)
        {
            a++;
        }
        public void ChangeLabel(Label l)
        {
            l.Text = "456";
        }
        public void ChangeB(ref int b, out int c)
        {
            b++;
            c = 7;
        }
    }
}
