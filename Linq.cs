using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Concepts
{
    internal class Linq
    {
        public void Run1()
        {
            // select * 
            // from tbl
            // where condition
            int[] nums = { 1, 4, 77, -87, 22 };
            foreach (int i in nums)
            {

            }
            var list=
                from x in nums
                where x > 0
                select x;
            var list2= from x in list
                       where x > 12
                       select x;
        }
        public void Run2()
        {
            // when I have a class with details that called "list":
            var myList1 = from x in list
                          where x.Id == 1
                          select x;
            ////////////////////////////////////////////////////////
            var myList2 = from x in list
                          where x.Id == 1 && x.FirstName == "Yossi" || x.FirstName == "Koby"
                          select (x.Price, x.LastName);
            ////////////////////////////////////////////////////////
        }

    }
}
