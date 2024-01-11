using BlazorObserver.Interfaces;
using BlazorObserver.Models;

namespace BlazorObserver.Observers
{
    public class ConcreteObserverA : IObserver
    {
        public bool ReactedToEvent { get; private set; }

        public void Update(ISubject subject, int newState)
        {
            ReactedToEvent = ((subject as Subject).State < 3);
        }
    }

}
