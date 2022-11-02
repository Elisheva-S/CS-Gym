using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Concepts
{
    public interface ITax
    {
         int MAAM(int price);
        int IncomminTax(int price);
    }
    public interface INewTax:ITax
    {

    }
    public class ImplementInterfaces : ITax, INewTax
    {
        public int IncomminTax(int price)
        {
            return price;
        }

        public int MAAM(int price)
        {
            return price;
        }
    }
    public class Eilat : ITax
    {
        public int IncomminTax(int price)
        {
            return 0;
        }

        public int MAAM(int price)
        {
            return 0;
        }
    }
    public class Regular : ITax
    {
        public int IncomminTax(int price)
        {
            return price*2;
        }

        public int MAAM(int price)
        {
            return price*2;
        }
    }
    public class InterfacesSample
    {
        public void Run()
        {
            ITax[] arr = new ITax[2];
            arr[0] = new Eilat();
            arr[1] = new Regular();
            arr[0].MAAM(10);
            arr[0].IncomminTax(10);
            Test(arr[0]);
            Eilat eilat = new Eilat();
            Test(eilat);
        }
        public void Test(ITax t)
        {

        }
        
    }
}
