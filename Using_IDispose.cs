using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Concepts
{
    class MakeBigRequest:IDisposable
    {
        public void Dispose()
        {
            Release();
        }

        public void Operate()
        {
            //takes huge memory
            //create temp DB
        }
        public void Release()
        {
            //drop temp DB
        }
    }
    internal class Using_IDispose
    {
        public void Run()
        {
            MakeBigRequest make=new MakeBigRequest();
            make.Operate();
            //release resources
            make.Release();

            make.Dispose();
            using (MakeBigRequest m = new MakeBigRequest())
            {
                m.Operate();
            }
        }
        public void Example()
        {
            using(FileStream f=System.IO.File.OpenRead(""))
            {
            }
        }
    }
}
