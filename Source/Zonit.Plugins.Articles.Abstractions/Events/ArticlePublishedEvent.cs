namespace Zonit.Plugins.Articles.Abstractions.Events;

public class ArticlePublishedEvent
{
    public Guid Id { get; set; }
    public string Content { get; set; } = string.Empty;
}