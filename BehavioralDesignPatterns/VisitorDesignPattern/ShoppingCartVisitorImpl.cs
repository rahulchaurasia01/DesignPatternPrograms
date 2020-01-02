using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehavioralDesignPatterns.VisitorDesignPattern
{
    class ShoppingCartVisitorImpl : IShoppingCartVisitor
    {
        public int Visit(Book book)
        {
            int cost;
            if (book.GetPrice() > 50)
                cost = book.GetPrice() - 5;
            else
                cost = book.GetPrice();

            Console.WriteLine("Book ISBN:: {0} Cost = {1}", book.GetIsbnNumber(), cost);
            return cost;
        }

        public int Visit(Fruit fruit)
        {
            int cost = fruit.GetPricePerKg() * fruit.GetWeight();
            Console.WriteLine(fruit.GetName() + " cost = " + cost);
            return cost;

        }
        
    }
}
