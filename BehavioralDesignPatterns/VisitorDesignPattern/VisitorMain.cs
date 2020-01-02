/*
 *  Purpose: Program for Testing the Observer Design Pattern Program. 
 * 
 *  @author  Rahul Chaurasia
 *  @version 1.0
 *  @since   02-01-2019
 */

using System;

namespace DesignPatternPrograms.BehavioralDesignPatterns.VisitorDesignPattern
{
    class VisitorMain
    {
        /// <summary>
        /// This Method is used to test the Visitor Class.
        /// </summary>
        public static void Visitor()
        {
            try
            {

                Console.WriteLine();
                Console.WriteLine("-----------------Visitor Design Pattern Program-----------------");
                Console.WriteLine();


                IItemElement[] items = new IItemElement[]{new Book(20, "1234"),new Book(100, "5678"),
                        new Fruit(10, 2, "Banana"), new Fruit(5, 5, "Apple")};

                int total = CalculatePrice(items);
                Console.WriteLine("Total Cost = " + total);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }

        private static int CalculatePrice(IItemElement[] items)
        {
            IShoppingCartVisitor visitor = new ShoppingCartVisitorImpl();
            int sum = 0;
            foreach(IItemElement item in items)
            {
                sum += item.Accept(visitor);
            }
            return sum;
        }
    }
}
