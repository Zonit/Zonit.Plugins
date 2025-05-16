namespace Zonit.Plugins.Articles.Abstractions;

/// <summary>
/// Reprezentuje zdarzenie, które wystêpuje, gdy opis artyku³u zostaje zaktualizowany.
/// </summary>
/// <remarks>Zdarzenie zawiera unikalny identyfikator artyku³u oraz jego zaktualizowany opis. Mo¿e byæ u¿ywane do œledzenia zmian opisów artyku³ów w systemie.</remarks>
public class ArticleDescriptionUpdatedEvent
{
    public required Guid Id { get; set; }
    public required string Description { get; set; }
}