namespace Zonit.Plugins.Articles.Abstractions.Events;

public class ArticleImageAddedEvent
{
    public Guid ArticleId { get; set; }
    public Guid ImageName { get; set; }
    public byte[] Image { get; set; } = [];
    public string Type { get; set; } = string.Empty;
}
