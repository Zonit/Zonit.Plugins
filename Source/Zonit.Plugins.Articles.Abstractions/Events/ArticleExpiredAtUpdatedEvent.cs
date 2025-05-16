namespace Zonit.Plugins.Articles.Abstractions.Events;

public class ArticleExpiredAtUpdatedEvent
{
    public Guid Id { get; set; }
    public DateTime ExpiresAt { get; set; }
}
