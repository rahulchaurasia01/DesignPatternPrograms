namespace DesignPatternPrograms.StructuralDesignPatterns.AdapterDesignPattern
{
    class SocketClassAdapterImpl : Socket, ISocketAdapter
    {

        public Volt Get120Volt()
        {
            return GetVolt();
        }

        public Volt Get12Volt()
        {
            Volt volt = GetVolt();
            return ConvertVolt(volt, 10);
        }

        public Volt Get3Volt()
        {
            Volt v = GetVolt();
            return ConvertVolt(v, 40);
        }

        private Volt ConvertVolt(Volt v, int i)
        {
            return new Volt(v.GetVolts() / i);
        }


    }
}
