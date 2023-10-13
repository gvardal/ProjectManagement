using EventBus.RabbitMQ.IntegrationEventHandler;
using EventBus.RabbitMQ.IntegrationEvents;

namespace EventBus.RabbitMQ.Subscription
{
    public class SubscriptionManager : ISubscriptionManager
    {
        private readonly Dictionary<string, List<SubcriptionInfo>> _handlers;
        private readonly List<Type> _eventTypes;
        public Func<string, string> eventNameGetter;

        public SubscriptionManager(Func<string, string> eventNameGetter)
        {
            this.eventNameGetter = eventNameGetter;
            _handlers = new Dictionary<string, List<SubcriptionInfo>>();
            _eventTypes = new List<Type>();
        }

        public bool IsEmpty => !_handlers.Keys.Any();

        public void Clear() => _handlers.Clear();

        public event EventHandler<string> OnEventRemoved;

        public void AddSubscription<T, TH>()
            where T : IntegrationEventBase
            where TH : IIntegrationEventHandler<T>
        {
            var eventName = GetEventKey<T>();
            AddSubscription(typeof(TH), eventName);
            if (!_eventTypes.Contains(typeof(T)))
            {
                _eventTypes.Add(typeof(T));
            }
        }

        private void AddSubscription(Type handlerType, string eventName)
        {
            if (!HasSubscriptionForEvent(eventName))
            {
                _handlers.Add(eventName, new List<SubcriptionInfo>());
            }
            if (_handlers[eventName].Any(s => s.HandlerType == handlerType))
            {
                throw new ArgumentException($"Handler Type {handlerType.Name} already registered for {eventName}", nameof(handlerType));
            }
            _handlers[eventName].Add(SubcriptionInfo.Typed(handlerType));
        }

        public string GetEventKey<T>()
        {
            string eventName = typeof(T).Name;
            return eventNameGetter(eventName);
        }

        public Type GetEventTypeByName(string eventName) => _eventTypes.SingleOrDefault(t => t.Name == eventName)!;

        public bool HasSubscriptionForEvent<T>() where T : IntegrationEventBase
        {
            var key = GetEventKey<T>();
            return HasSubscriptionForEvent(key);
        }

        public bool HasSubscriptionForEvent(string eventName) => _handlers.ContainsKey(eventName);

        public void RemoveSubscription<T, TH>()
            where T : IntegrationEventBase
            where TH : IIntegrationEventHandler<T>
        {
            var handlerToRemove = FindSubscriptionToRemove<T, TH>();
            var eventName = GetEventKey<T>();
            RemoveHandler(eventName, handlerToRemove);
        }

        private void RemoveHandler(string eventName, SubcriptionInfo handlerToRemove)
        {
            if (handlerToRemove is not null)
            {
                _handlers[eventName].Remove(handlerToRemove);
                if (!_handlers[eventName].Any())
                {
                    _handlers.Remove(eventName);
                    var eventType = _eventTypes.SingleOrDefault(t => t.Name == eventName);
                    if (eventType is not null)
                    {
                        _eventTypes.Remove(eventType);
                    }
                    RiseOnEventRemove(eventName);
                }
            }
        }

        private void RiseOnEventRemove(string eventName)
        {
            var handler = OnEventRemoved;
            handler?.Invoke(this, eventName);
        }

        private SubcriptionInfo FindSubscriptionToRemove<T, TH>()
            where T : IntegrationEventBase
            where TH : IIntegrationEventHandler<T>
        {
            var eventName = GetEventKey<T>();
            return FindSubscriptionToRemove(eventName, typeof(TH));
        }

        private SubcriptionInfo FindSubscriptionToRemove(string eventName, Type handlerType)
        {
            if (!HasSubscriptionForEvent(eventName)) { return null; }
            return _handlers[eventName].SingleOrDefault(s => s.HandlerType == handlerType);
        }

        public IEnumerable<SubcriptionInfo> GetHandlersForEvent<T>() where T : IntegrationEventBase
        {
            var key = GetEventKey<T>();
            return GetHandlersForEvent(key);
        }

        public IEnumerable<SubcriptionInfo> GetHandlersForEvent(string eventName) => _handlers[eventName];
    }
}
