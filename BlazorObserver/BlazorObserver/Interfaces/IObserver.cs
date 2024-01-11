namespace BlazorObserver.Interfaces
{
    public interface IObserver
    {
        void Update(ISubject subject, int newState);
    }

}
