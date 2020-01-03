using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehavioralDesignPatterns.MediatorDesignPattern
{
    public interface IChatMediator
    {

        public void SendMessage(string msg, User user);

        public void AddUser(User user);

    }
}
