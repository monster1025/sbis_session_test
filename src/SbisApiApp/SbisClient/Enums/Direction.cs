using System.Runtime.Serialization;

namespace SbisApiApp.SbisClient.Enums;

public enum Direction
{
    /// <summary>Входящий.</summary>
    [EnumMember(Value = "incoming")] Incoming = 1,
    /// <summary>Исходящий.</summary>
    [EnumMember(Value = "outgoing")] Outgoing = 2,
}