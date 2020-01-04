namespace DesignPatternPrograms.StructuralDesignPatterns.FacadeDesignPattern
{
    class CreateAddressBook : IAddressBook
    {

        public string Name { set; get; }
        
        public string MobileNumber { get; set; }

        public string EmailId { get; set; }

        public string Address { get; set; }

        public string Zip { get; set; }
    }
}
