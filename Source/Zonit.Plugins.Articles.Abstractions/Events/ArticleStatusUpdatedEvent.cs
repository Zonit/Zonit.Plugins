namespace Zonit.Plugins.Articles.Abstractions.Events;

public class ArticleStatusUpdatedEvent
{
    public Guid Id { get; set; }
    public string Status { get; set; } = string.Empty;
}
