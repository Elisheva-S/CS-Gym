using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Concepts
{
    internal class Generics
    {
        public void Run()
        {
            List<string> list = new List<string>();
            list.Add("aaa");
            List<int> list2 = new List<int>();
            list2.Add(456);
            var p = new Point(123, 321);
            string s = Func<Point, string>(p, "This is the point!");

            //  public class Sample<T> where T:class
            //Sample<Point> sample = new Sample<Point>();

            //  public class Sample<T> where T:struct
            //Sample<MyStruct> sample2 = new Sample<MyStruct>();

            //sample.SetItem(new Point(10, 15));

            //  public class Sample<T> where T:a
            //Sample<b> sample=new Sample<b>();
            //Sample<c> sample2 = new Sample<c>();
            //Sample<a> sample3 = new Sample<a>();

            //public class Sample<T> where T:IEnumerable<T>
            Sample <List<int>,int> sample = new Sample <List<int>,int>();

        }
        public string Func<T, Z>(T o, Z y)
        {
            string s = o.ToString() + " " + y.ToString();
            return s;
        }
        struct MyStruct
        {
            public string Name;
            public string Value;
        }
        public class Sample<T,Z> where T:IEnumerable<Z>
        {
            public void SetItem(T item)
            {

            }
        }
        public class PrintManager<T>
        {

        }
       public class a { }
       public class b:a { }
       public class c :a { }
    }
}
