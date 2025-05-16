namespace Zonit.Plugins.Articles.Abstractions.Events;

public class ArticleCultureUpdatedEvent
{
    public Guid Id { get; set; }
    public string Culture { get; set; } = string.Empty;
}
