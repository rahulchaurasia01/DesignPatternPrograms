using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.StructuralDesignPatterns.AdapterDesignPattern
{
    class AdapterMain
    {
        /// <summary>
        /// This Method is used to test the AdapterDesign Pattern Class.
        /// </summary>
        public static void Adapter()
        {

            try
            {
                Console.WriteLine();
                Console.WriteLine("-----------------Adapter Design Pattern Program-----------------");
                Console.WriteLine();

                TestClassAdapter();
                TestObjectAdapter();



            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }

        }


        private static void TestObjectAdapter()
        {
            ISocketAdapter socketAdapter = new SocketObjectAdapterImpl();
            Volt v3 = GetVolt(socketAdapter, 3);
            Volt v12 = GetVolt(socketAdapter, 12);
            Volt v120 = GetVolt(socketAdapter, 120);
            Console.WriteLine("v3 Volts using Object Adapter= {0}", v3.GetVolts());
            Console.WriteLine("v12 Volts using Object Adapter= {0}", v12.GetVolts());
            Console.WriteLine("v120 Volts using Object Adapter= {0}", v120.GetVolts());
        }

        private static void TestClassAdapter()
        {
            ISocketAdapter socketAdapter = new SocketClassAdapterImpl();
            Volt v3 = GetVolt(socketAdapter, 3);
            Volt v12 = GetVolt(socketAdapter, 12);
            Volt v120 = GetVolt(socketAdapter, 120);
            Console.WriteLine("v3 Volts using Class Adapter= {0}", v3.GetVolts());
            Console.WriteLine("v12 Volts using Class Adapter= {0}", v12.GetVolts());
            Console.WriteLine("v120 Volts using Class Adapter= {0}", v120.GetVolts());

        }

        private static Volt GetVolt(ISocketAdapter socketAdapter, int v)
        {
            return v switch
            {
                3 => socketAdapter.Get3Volt(),
                12 => socketAdapter.Get12Volt(),
                120 => socketAdapter.Get120Volt(),
                _ => socketAdapter.Get120Volt(),
            };
        }
    }
}
