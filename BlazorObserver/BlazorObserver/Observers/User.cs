namespace BlazorObserver.Observers
{
    using BlazorObserver.Interfaces;
    using BlazorObserver.Models;
    using System;

    public class User : IMessageObserver
    {
        public string Name { get; }

        public User(string name)
        {
            Name = name;
        }

        public void NotifyNewMessage(Message message)
        {
            Console.WriteLine($"{Name} recibió un nuevo mensaje: {message.Text}");
        }
    }

}
