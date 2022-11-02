using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Concepts
{
    internal class Foreach
    {
        public void Run()
        {
            int sum = 0;
            int[] arr = new int[10];
            foreach (var item in arr)
            {
                sum += item;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
        }
        public void RunMyItemsArray()
        {
            Items items = new Items();
            string allStrings = "";
            foreach (var item in items)
            {
                allStrings+=item.ToString();
            }
        }
    }
    public class Items : IEnumerable,IEnumerator
    {
        public string[] arr = { "ball", "drink", "bag" };
        int id = -1;
        public object Current
        {
            get { return arr[id]; }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (id<arr.Length)
            {
                id++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            id = -1;
        }


        
    }
}

