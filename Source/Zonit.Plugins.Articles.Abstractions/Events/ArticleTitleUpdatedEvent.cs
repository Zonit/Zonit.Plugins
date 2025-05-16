namespace Zonit.Plugins.Articles.Abstractions.Events;

public class ArticleTitleUpdatedEvent
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
}
