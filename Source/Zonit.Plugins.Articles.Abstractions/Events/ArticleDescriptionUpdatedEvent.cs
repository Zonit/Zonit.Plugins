namespace Zonit.Plugins.Articles.Abstractions;

/// <summary>
/// Reprezentuje zdarzenie, kt�re wyst�puje, gdy opis artyku�u zostaje zaktualizowany.
/// </summary>
/// <remarks>Zdarzenie zawiera unikalny identyfikator artyku�u oraz jego zaktualizowany opis. Mo�e by� u�ywane do �ledzenia zmian opis�w artyku��w w systemie.</remarks>
public class ArticleDescriptionUpdatedEvent
{
    public required Guid Id { get; set; }
    public required string Description { get; set; }
}