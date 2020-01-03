/*
 *  Purpose: Program for Testing the Proxy Design Pattern Program. 
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   03-01-2019
 */

using System;

namespace DesignPatternPrograms.StructuralDesignPatterns.ProxyDesignPattern
{
    class ProxyMain
    {
        /// <summary>
        /// This Method is used to test the ProxyDesign Pattern Class.
        /// </summary>
        public static void Proxy()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("-----------------Proxy Design Pattern Program-----------------");
                Console.WriteLine();

                ICommandExecutor commandExecutor = new CommandExecutorProxy("Admin", "");
                commandExecutor.RunCommand(@"C:\Users\User mkdir Sonu");
                commandExecutor.RunCommand(" rm -rf abc.pdf");

            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

    }
}
