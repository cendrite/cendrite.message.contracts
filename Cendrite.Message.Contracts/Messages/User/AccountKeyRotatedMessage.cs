using Cendrite.Message.Contracts.Abstractions;

namespace Cendrite.Message.Contracts.Messages.User;

public sealed class AccountKeyRotatedMessage : IBaseMessage
{
    public Guid Id { get; } = Guid.NewGuid();
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
    public required Guid CorrelationId { get; init; }
    public Guid? CausationId { get; init; } = null;
    public required Guid UserId { get; init; }
    public required Guid DeviceId { get; init; }
    public required Guid ConnectionId { get; init; }
    public required string DeviceName { get; init; }
}
