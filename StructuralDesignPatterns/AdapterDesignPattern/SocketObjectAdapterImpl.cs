﻿namespace DesignPatternPrograms.StructuralDesignPatterns.AdapterDesignPattern
{
    class SocketObjectAdapterImpl : ISocketAdapter
    {

        private Socket socket = new Socket();

        public Volt Get120Volt()
        {
            return socket.GetVolt();
        }

        public Volt Get12Volt()
        {
            Volt volt = socket.GetVolt();
            return ConvertVolt(volt, 10);
        }

        public Volt Get3Volt()
        {
            Volt volt = socket.GetVolt();
            return ConvertVolt(volt, 40);
        }

        private Volt ConvertVolt(Volt volt, int v)
        {
            return new Volt(volt.GetVolts() / v);
        }


    }
}
