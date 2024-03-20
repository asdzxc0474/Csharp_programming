    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Class1
    {
        public int classID;
        public string className;
        public Class1(int ID, string Name) 
        {
            classID = ID;
            className = Name;
        }
        private void showID()
        {
            Console.WriteLine($"ID:{classID}");
        }
        private void showName()
        {
            Console.WriteLine($"ClassName:{className}");
        }
        public void showNameAndID()
        {
            showID();
            showName();
        }
    }
}
