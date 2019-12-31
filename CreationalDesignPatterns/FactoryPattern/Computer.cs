namespace DesignPatternPrograms.CreationalDesignPatterns.FactoryPattern
{
    public abstract class Computer
    {

        public abstract string GetRAM();

        public abstract string GetHDD();

        public abstract string GetCPU();


        public override string ToString()
        {
            return GetRAM()+", " + GetHDD()+", " + GetCPU();
        }
    }
}
