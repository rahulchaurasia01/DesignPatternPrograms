namespace DesignPatternPrograms.StructuralDesignPatterns.FacadeDesignPattern
{
    public interface IAddressBook
    {

        public string Name { set; get; }

        public string MobileNumber { set; get; }

        public string EmailId { set; get; }
        
        public string Address { set; get; }
        
        public string Zip { set; get; }
        

    }
}
