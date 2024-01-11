using BlazorObserver.Interfaces;
using BlazorObserver.Models;

namespace BlazorObserver.Observers
{
    public class ConcreteObserverB : IObserver
    {
        public bool ReactedToEvent { get; private set; }

        public void Update(ISubject subject, int newState)
        {
            ReactedToEvent = ((subject as Subject).State == 0 || (subject as Subject).State >= 2);
        }
    }
}
