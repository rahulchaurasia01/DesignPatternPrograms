using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehavioralDesignPatterns.VisitorDesignPattern
{
    public interface IItemElement
    {


        public int Accept(IShoppingCartVisitor shoppingCartVisitor);

    }
}
