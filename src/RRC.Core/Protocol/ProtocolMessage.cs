namespace RRC.Core.Protocol;

public sealed record ProtocolMessage(
    MessageType Type,
    Guid RequestId,
    string? Payload);