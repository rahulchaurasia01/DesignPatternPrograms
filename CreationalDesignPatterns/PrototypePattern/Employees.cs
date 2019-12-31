using System;
using System.Collections.Generic;

namespace DesignPatternPrograms.CreationalDesignPatterns.PrototypePattern
{
    class Employees : ICloneable
    {

        private List<string> empList;

        public Employees()
        {
            empList = new List<string>();
        }

        public Employees(List<string> emp)
        {
            empList = emp;
        }

        public void LoadEmp()
        {
            empList.Add("Rahul");
            empList.Add("Sonu");
            empList.Add("Lucy");
            empList.Add("Pooja");
        }

        public List<string> GetEmp()
        {
            return empList;
        }

        public object Clone()
        {
            List<string> tempEmp = new List<string>();
            foreach (string str in GetEmp())
                tempEmp.Add(str);

            return new Employees(tempEmp);
        }
    }
}
