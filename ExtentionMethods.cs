using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Concepts
{
    public class Utilities
    {
        public static int DotsCounter(string s)
        {
            return s.Split('.').Count() - 1;
        }
    }
    internal class ExtentionMethods
    {
        public void Run()
        {
            int count = 12;
            string s = "aa.ghf.65465.666.hgfg.656";
            Utilities.DotsCounter(s);
            s.DotsCounter(count);
        }
       
    }
    public static class ExtMethods
    {
        public static int DotsCounter(this string s,int count)
        {
            return s.Split('.').Count() - 1;
        }
    }
}
