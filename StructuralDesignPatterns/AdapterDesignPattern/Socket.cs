namespace DesignPatternPrograms.StructuralDesignPatterns.AdapterDesignPattern
{
    class Socket
    {

        public Volt GetVolt()
        {
            return new Volt(120);
        }

    }
}
