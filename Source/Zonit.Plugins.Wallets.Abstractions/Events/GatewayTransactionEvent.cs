namespace Zonit.Plugins.Wallets.Abstractions;

/// <summary>
/// Event that represents a transaction processed through a payment gateway.
/// </summary>
public class GatewayTransactionEvent
{
    public required Guid Id { get; set; }
    public required Guid DepositId { get; set; }
    public Guid? OrganizationId { get; set; }
    public Guid? UserId { get; set; }

    /// <summary>
    /// The amount of the transaction, represented as a decimal value.
    /// </summary>
    public required decimal Amount { get; set; }

    /// <summary>
    /// Gets or sets the ISO 4217 currency code associated with the transaction or amount.
    /// </summary>
    public required string Currency { get; set; }
    public required string Status { get; set; }
}
