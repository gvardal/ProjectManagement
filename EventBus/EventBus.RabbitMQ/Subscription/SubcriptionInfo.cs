namespace EventBus.RabbitMQ.Subscription
{
    public class SubcriptionInfo
    {
        public Type HandlerType { get; }

        public SubcriptionInfo(Type handlerType)
        {
            HandlerType = handlerType;
        }

        public static SubcriptionInfo Typed(Type handlerType)
        {
            return new SubcriptionInfo(handlerType);
        }
    }
}
