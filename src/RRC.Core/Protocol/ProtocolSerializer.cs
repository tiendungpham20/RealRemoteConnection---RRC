using System.Text.Json;

namespace RRC.Core.Protocol;

public static class ProtocolSerializer
{
    private static readonly JsonSerializerOptions Options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public static string Serialize(ProtocolMessage message)
    {
        return JsonSerializer.Serialize(message, Options);
    }

    public static ProtocolMessage Deserialize(string json)
    {
        return JsonSerializer.Deserialize<ProtocolMessage>(json, Options)
            ?? throw new InvalidOperationException("Invalid RRC protocol message.");
    }
}