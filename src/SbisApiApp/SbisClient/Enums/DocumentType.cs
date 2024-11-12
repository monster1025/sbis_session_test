using System.Runtime.Serialization;

namespace SbisApiApp.SbisClient.Enums;

[AttributeUsage(AttributeTargets.Field)]
public sealed class DirectionTypeAttribute : Attribute
{
    public DirectionTypeAttribute(Direction direction)
    {
        Direction = direction;
    }

    public Direction Direction { get; }
}

public enum DocumentType
{
    [DirectionType(Direction.Incoming)] 
    АктСверВх = 0,

    [DirectionType(Direction.Incoming)]
    ДоговорВх = 1,
    
    [DirectionType(Direction.Incoming)]
    ДокОтгрВх = 2,
    
    [DirectionType(Direction.Incoming)]
    ЗаказВх = 3,
    
    [DirectionType(Direction.Incoming)]
    КоррВх = 4,
    
    [DirectionType(Direction.Incoming)]
    СчетВх = 5,
    
    [DirectionType(Direction.Incoming)]
    ФактураВх = 6,
    
    [DirectionType(Direction.Incoming)]
    CorrIn = 7,
    
    [DirectionType(Direction.Incoming)]
    ReturnIn = 8,
    
    [DirectionType(Direction.Incoming)]
    DeviationActIn = 9,

    [EnumMember(Value = "АктСверИсх"), DirectionType(Direction.Outgoing)]
    ActSverOutgoing = 10,

    [EnumMember(Value = "ДоговорИсх"), DirectionType(Direction.Outgoing)]
    AgreementOutgoing = 11,

    [EnumMember(Value = "ДокОтгрИсх"), DirectionType(Direction.Outgoing)]
    DocOtgrOutgoing = 12,

    [EnumMember(Value = "ЗаказИсх"), DirectionType(Direction.Outgoing)]
    OrderOutgoing = 13,

    [EnumMember(Value = "КоррИсх"), DirectionType(Direction.Outgoing)]
    CorrOutgoing = 14,

    [EnumMember(Value = "СчетИсх"), DirectionType(Direction.Outgoing)]
    InvOutgoing = 15,

    [EnumMember(Value = "ФактураИсх"), DirectionType(Direction.Outgoing)]
    TextureOutgoing = 16,

    [EnumMember(Value = "CorrOut"), DirectionType(Direction.Outgoing)]
    CorrOut = 17,

    [EnumMember(Value = "ReturnOut"), DirectionType(Direction.Outgoing)]
    ReturnOut = 18,

    [EnumMember(Value = "DeviationActOut"), DirectionType(Direction.Outgoing)]
    DeviationActOut = 19,
}