using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.BehavioralDesignPatterns.ObserverDesignPattern
{
    public interface IObserver
    {

        void Update(ISubject subject);

    }
}
