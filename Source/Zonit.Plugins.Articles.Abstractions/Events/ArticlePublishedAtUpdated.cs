namespace Zonit.Plugins.Articles.Abstractions.Events;

public class ArticlePublishedAtUpdated
{
    public Guid Id { get; set; }
    public DateTime PublishedAt { get; set; }
}
