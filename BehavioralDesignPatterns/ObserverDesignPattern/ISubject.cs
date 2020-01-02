using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehavioralDesignPatterns.ObserverDesignPattern
{
    public interface ISubject
    {


        void Attach(IObserver observer);


        void Detach(IObserver observer);


        void Notify();

    }
}
