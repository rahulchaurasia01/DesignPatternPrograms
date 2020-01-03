namespace DesignPatternPrograms.BehavioralDesignPatterns.MediatorDesignPattern
{
    public abstract class User
    {

        protected IChatMediator chatMediator;
        protected string name;


        public User(IChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }


        public abstract void Send(string msgSend);

        public abstract void Receive(string msgReceive);


    }
}
