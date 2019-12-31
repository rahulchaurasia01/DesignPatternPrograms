/*
 *  Purpose: Program for testing the Factory Pattern Program.
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   31-12-2019
 */

using System;

namespace DesignPatternPrograms.CreationalDesignPatterns.FactoryPattern
{
    class Main
    {
        /// <summary>
        /// This Method is used to test the FactoryPattern Class program
        /// </summary>
        public static void StartMain()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("-----------------Factory Pattern Program-----------------");
                Console.WriteLine();


                Computer pc = ComputerFactory.GetComputer("Pc", "8.0 Gb", "10 TB", "2.4 Ghz");
                Computer server = ComputerFactory.GetComputer("Server", "16 Gb", "25 TB", "2.9 Ghz");
                Console.WriteLine("Pc Details are: {0}", pc.ToString());
                Console.WriteLine("Server Details are: {0}", server.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
