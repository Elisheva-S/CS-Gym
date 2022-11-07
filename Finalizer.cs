using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Concepts
{
    internal class Finalizer
    {
        FileStream fileStream;
        public void Run()
        {
            try
            {
                fileStream = System.IO.File.OpenRead("");
                for (int i = 0; i < 100; i++)
                {
                    Finalizer finalizer = new Finalizer();
                }
            }
            finally 
            { 
                fileStream.Close(); 
            }
        }
        public Finalizer()
        {
            //constructor
        }
        ~Finalizer()
        {
            //destructor called also finalizer
            fileStream.Close();

        }
    }
}
