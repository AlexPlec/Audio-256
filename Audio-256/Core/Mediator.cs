namespace Audio_256.Core
{
    public interface IMediator
    {
        void Subscribe(string message, Action<object?> handler);
        void Unsubscribe(string message, Action<object?> handler);
        void Publish(string message, object? data = null);
    }

    internal class Mediator : IMediator
    {
        private readonly Dictionary<string, List<Action<object?>>> _subscribers
            = new Dictionary<string, List<Action<object?>>>();

        public void Subscribe(string message, Action<object?> handler)
        {
            if (!_subscribers.ContainsKey(message))
            {
                _subscribers[message] = new List<Action<object?>>();
            }

            _subscribers[message].Add(handler);
        }

        public void Unsubscribe(string message, Action<object?> handler)
        {
            if (_subscribers.ContainsKey(message))
            {
                _subscribers[message].Remove(handler);
                if (_subscribers[message].Count == 0)
                {
                    _subscribers.Remove(message);
                }
            }
        }

        public void Publish(string message, object? data = null)
        {
            if (_subscribers.TryGetValue(message, out var handlers))
            {
                foreach (var handler in handlers.ToArray()) // Prevent modification during iteration
                {
                    handler.Invoke(data);
                }
            }
        }
    }
}
