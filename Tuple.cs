using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Concepts
{
    internal class Tuple
    {
        public void Run()
        {
            int i;
            string name;
            (int id, string fName, string lName) person;
            person = (123, "Elisheva", "Shzigel");
            person.id = 456;
            person.fName = "Yaacov";
            person.lName = "cohen";
            var newPerson=CreatePerson();
            person.id = newPerson.id;
            person.fName = newPerson.fName;
            person.lName = newPerson.lName;
        }
        public (int id,string fName,string lName) CreatePerson()
        {
            (int id, string fName, string lName) val;
            val.id = 888;
            val.fName ="Chaim";
            val.lName = "Levi";
            return val;
        }
    }
}
