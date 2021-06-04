using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;
using System.Collections;

namespace ExamObserverPattern2
{
    public class MainData : Subject
    {
        int _value = 0;
        IList _observers = new ArrayList();
        public void notifyObservers()
        {
            foreach (Observer o in _observers)
                o.update(_value);
        }

        public void registerObserver(Observer o)
        {
            _observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            _observers.Remove(o);
        }
        public void setValue(int value)
        {
            _value = value;
            notifyObservers();
        }
    }
}
