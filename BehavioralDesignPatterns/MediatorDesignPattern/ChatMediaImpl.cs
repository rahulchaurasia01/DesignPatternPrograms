using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehavioralDesignPatterns.MediatorDesignPattern
{
    class ChatMediaImpl : IChatMediator
    {

        private List<User> users;

        public ChatMediaImpl()
        {
            this.users = new List<User>();
        }

        public void AddUser(User user)
        {
            this.users.Add(user);
        }

        public void SendMessage(string msg, User user)
        {
            foreach(User user1 in this.users)
            {
                if (user1 != user)
                    user1.Receive(msg);
            }
        }
    }
}
