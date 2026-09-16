using RRC.Core.Protocol;

namespace RRC.Core.Tests.Protocol;

public class ProtocolMessageTests
{
    [Fact]
    public void SerializeAndDeserialize_ShouldPreserveMessage()
    {
        var requestId = Guid.NewGuid();

        var message = new ProtocolMessage(
            MessageType.Hello,
            requestId,
            "RRC/1.0");

        var json = ProtocolSerializer.Serialize(message);
        var result = ProtocolSerializer.Deserialize(json);

        Assert.Equal(message.Type, result.Type);
        Assert.Equal(message.RequestId, result.RequestId);
        Assert.Equal(message.Payload, result.Payload);
    }

    [Fact]
    public void Serialize_ShouldUseCamelCaseProperties()
    {
        var message = new ProtocolMessage(
            MessageType.Ping,
            Guid.Empty,
            "test");

        var json = ProtocolSerializer.Serialize(message);

        Assert.Contains("\"type\"", json);
        Assert.Contains("\"requestId\"", json);
        Assert.Contains("\"payload\"", json);
    }
}