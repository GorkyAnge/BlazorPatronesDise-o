namespace BlazorObserver.Observers
{
    using BlazorObserver.Interfaces;
    using BlazorObserver.Models;
    using System;
    using System.Collections.Generic;

    public class ChatRoom
    {
        private List<IMessageObserver> observers = new List<IMessageObserver>();

        public void Attach(IMessageObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IMessageObserver observer)
        {
            observers.Remove(observer);
        }

        public void SendMessage(Message message)
        {
            Console.WriteLine($"Mensaje enviado: {message.Text}");
            NotifyObservers(message);
        }

        private void NotifyObservers(Message message)
        {
            foreach (var observer in observers)
            {
                observer.NotifyNewMessage(message);
            }
        }
    }

}
