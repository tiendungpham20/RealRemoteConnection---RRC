namespace RRC.Core.Protocol;

public enum MessageType
{
    Hello = 1,
    HelloResponse = 2,

    Authenticate = 10,
    AuthenticationResult = 11,

    SessionStart = 20,
    SessionEnd = 21,

    Frame = 30,
    Input = 31,
    Clipboard = 32,

    Ping = 40,
    Pong = 41,

    Error = 255
}