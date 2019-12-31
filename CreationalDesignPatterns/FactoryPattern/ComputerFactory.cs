using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.CreationalDesignPatterns.FactoryPattern
{
    class ComputerFactory
    {

        public static Computer GetComputer(string type, string ram, string hdd, string cpu)
        {
            if (type.ToLower().Equals("pc"))
                return new PC(cpu, hdd, ram);
            else if (type.ToLower().Equals("server"))
                return new Server(cpu, hdd, ram);
            else
                return null;
        }

    }
}
