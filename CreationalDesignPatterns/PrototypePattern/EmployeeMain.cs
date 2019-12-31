/*
 *  Purpose: Program for Testing the Prototype Program. 
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   31-12-2019
 */

using System;
using System.Collections.Generic;

namespace DesignPatternPrograms.CreationalDesignPatterns.PrototypePattern
{
    class EmployeeMain
    {
        /// <summary>
        /// This Method is Used to test the Prototype Pattern Program
        /// </summary>
        public static void Employee()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("-----------------Prototype Pattern Program-----------------");
                Console.WriteLine();

                Employees employees = new Employees();
                employees.LoadEmp();

                Employees employees1 = (Employees)employees.Clone();
                Employees employees2 = (Employees)employees.Clone();

                List<string> list = employees1.GetEmp();
                list.Add("Idiot");

                List<string> list1 = employees2.GetEmp();
                list1.Remove("Pooja");

                Console.Write("Employees:- ");
                foreach (string str in employees.GetEmp())
                    Console.Write(str + "  ");
                Console.WriteLine();

                Console.Write("Employees1:- ");
                foreach (string str in list)
                    Console.Write(str + "  ");
                Console.WriteLine();

                Console.Write("Employees2:- ");
                foreach (string str in list1)
                    Console.Write(str + "  ");
                Console.WriteLine();

            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
