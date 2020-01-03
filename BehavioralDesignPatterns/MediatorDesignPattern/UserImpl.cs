using System;

namespace DesignPatternPrograms.BehavioralDesignPatterns.MediatorDesignPattern
{
    class UserImpl : User
    {

        public UserImpl(IChatMediator chatMediator, string name) : base(chatMediator, name)
        {   
        }

        public override void Receive(string msgReceive)
        {
            Console.WriteLine("{0}: Received Message: {1}", this.name, msgReceive);
        }

        public override void Send(string msgSend)
        {
            Console.WriteLine("{0}: Sending Message= {1}", this.name, msgSend);
            chatMediator.SendMessage(msgSend, this);
        }
    }
}
