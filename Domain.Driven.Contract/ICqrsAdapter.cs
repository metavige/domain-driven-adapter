namespace Domain.Driven;

public interface ICqrsAdapter : IRequestSender, INotificationPublisher
{
}