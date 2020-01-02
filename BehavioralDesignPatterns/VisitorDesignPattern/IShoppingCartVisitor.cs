using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehavioralDesignPatterns.VisitorDesignPattern
{
    public interface IShoppingCartVisitor
    {

        public int Visit(Book book);

        public int Visit(Fruit fruit);

    }
}
