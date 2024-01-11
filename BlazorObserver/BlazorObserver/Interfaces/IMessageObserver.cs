using BlazorObserver.Models;

namespace BlazorObserver.Interfaces
{
    public interface IMessageObserver
    {
        void NotifyNewMessage(Message message);
    }

}
