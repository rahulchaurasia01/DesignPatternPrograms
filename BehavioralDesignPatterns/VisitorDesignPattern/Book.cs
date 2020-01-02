using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehavioralDesignPatterns.VisitorDesignPattern
{
    public class Book : IItemElement
    {


        private int price;
        private string isbnNumber;


        public Book(int price, string isbnNumber)
        {
            this.price = price;
            this.isbnNumber = isbnNumber;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public string GetIsbnNumber()
        {
            return this.isbnNumber;
        }

        public int Accept(IShoppingCartVisitor shoppingCartVisitor)
        {
            return shoppingCartVisitor.Visit(this);
        }
    }
}
