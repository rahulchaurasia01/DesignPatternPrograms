using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehavioralDesignPatterns.VisitorDesignPattern
{
    public class Fruit : IItemElement
    {

        private int pricePerKg;
        private int weight;
        private string name;


        public Fruit(int pricePerKg, int weight, string name)
        {
            this.pricePerKg = pricePerKg;
            this.weight = weight;
            this.name = name;
        }

        public int GetPricePerKg()
        {
            return this.pricePerKg;
        }

        public int GetWeight()
        {
            return this.weight;
        }

        public string GetName()
        {
            return this.name;
        }

        public int Accept(IShoppingCartVisitor shoppingCartVisitor)
        {
            return shoppingCartVisitor.Visit(this);
        }
    }
}
