/*
 *  Purpose: Program for Testing the Mediator Design Pattern Program. 
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   03-01-2019
 */

using System;

namespace DesignPatternPrograms.BehavioralDesignPatterns.MediatorDesignPattern
{
    class MediatorMain
    {
        /// <summary>
        /// This Method is used to test the MediatorMain Program Class.
        /// </summary>
        public static void Mediator()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("-----------------Mediator Design Pattern Program-----------------");
                Console.WriteLine();

                IChatMediator chatMediator = new ChatMediaImpl();
                User user1 = new UserImpl(chatMediator, "Pankaj");
                User user2 = new UserImpl(chatMediator, "Lisa");
                User user3 = new UserImpl(chatMediator, "Saurabh");
                User user4 = new UserImpl(chatMediator, "David");
                chatMediator.AddUser(user1);
                chatMediator.AddUser(user2);
                chatMediator.AddUser(user3);
                chatMediator.AddUser(user4);

                user1.Send("Hi All");

            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
