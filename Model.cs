using LoremNET;
using ProtoBuf;

namespace Habr.RedisCompression;

[ProtoContract]
public class Model
{
    [ProtoMember(32)] public int Counter { get; set; }
    [ProtoMember(31)]public DateTime SomeDate0 { get; set; }
    [ProtoMember(1)]public DateTime SomeDate1 { get; set; }
    [ProtoMember(2)]public DateTime SomeDate2 { get; set; }
    [ProtoMember(3)]public DateTime SomeDate3 { get; set; }
    [ProtoMember(4)]public DateTime SomeDate4 { get; set; }
    [ProtoMember(5)]public DateTime SomeDate5 { get; set; }
    [ProtoMember(6)]public DateTime SomeDate6 { get; set; }
    [ProtoMember(7)]public DateTime SomeDate7 { get; set; }
    [ProtoMember(8)]public DateTime SomeDate8 { get; set; }
    [ProtoMember(9)]public DateTime SomeDate9 { get; set; }
    [ProtoMember(10)]public string Text0 { get; set; }
    [ProtoMember(11)]public string Text1 { get; set; }
    [ProtoMember(12)]public string Text2 { get; set; }
    [ProtoMember(13)]public string Text3 { get; set; }
    [ProtoMember(14)]public string Text4 { get; set; }
    [ProtoMember(15)]public string Text5 { get; set; }
    [ProtoMember(16)]public string Text6 { get; set; }
    [ProtoMember(17)]public string Text7 { get; set; }
    [ProtoMember(18)]public string Text8 { get; set; }
    [ProtoMember(19)]public string Text9 { get; set; }
    [ProtoMember(20)]public Guid SomeID0 { get; set; }
    [ProtoMember(21)]public Guid SomeID1 { get; set; }
    [ProtoMember(22)]public Guid SomeID2 { get; set; }
    [ProtoMember(23)]public Guid SomeID3 { get; set; }
    [ProtoMember(24)]public Guid SomeID4 { get; set; }
    [ProtoMember(25)]public Guid SomeID5 { get; set; }
    [ProtoMember(26)]public Guid SomeID6 { get; set; }
    [ProtoMember(27)]public Guid SomeID7 { get; set; }
    [ProtoMember(28)]public Guid SomeID8 { get; set; }
    [ProtoMember(29)]public Guid SomeID9 { get; set; }

    [ProtoMember(30)]public List<InternalEntity> EntitiesArray { get; set; } = new List<InternalEntity>();
    public static Model Generate()
    {
        var rng = new Random();
        var entryCount = rng.Next(45, 55);
        var entries = new List<InternalEntity>(entryCount);
        for(int i = 0; i < entryCount; ++i)
            entries.Add(InternalEntity.Generate());
        
        return new()
        {
            SomeDate0 = Lorem.DateTime(),
            SomeDate1 = Lorem.DateTime(),
            SomeDate2 = Lorem.DateTime(),
            SomeDate3 = Lorem.DateTime(),
            SomeDate4 = Lorem.DateTime(),
            SomeDate5 = Lorem.DateTime(),
            SomeDate6 = Lorem.DateTime(),
            SomeDate7 = Lorem.DateTime(),
            SomeDate8 = Lorem.DateTime(),
            SomeDate9 = Lorem.DateTime(),
            Text0 = Lorem.Words(10, 50),
            Text1 = Lorem.Words(10, 50),
            Text2 = Lorem.Words(10, 50),
            Text3 = Lorem.Words(10, 50),
            Text4 = Lorem.Words(10, 50),
            Text5 = Lorem.Words(10, 50),
            Text6 = Lorem.Words(10, 50),
            Text7 = Lorem.Words(10, 50),
            Text8 = Lorem.Words(10, 50),
            Text9 = Lorem.Words(10, 50),
            SomeID0 = Guid.NewGuid(),
            SomeID1 = Guid.NewGuid(),
            SomeID2 = Guid.NewGuid(),
            SomeID3 = Guid.NewGuid(),
            SomeID4 = Guid.NewGuid(),
            SomeID5 = Guid.NewGuid(),
            SomeID6 = Guid.NewGuid(),
            SomeID7 = Guid.NewGuid(),
            SomeID8 = Guid.NewGuid(),
            SomeID9 = Guid.NewGuid(),
            EntitiesArray = entries
        };
    }
}

[ProtoContract]
public class InternalEntity
{
    [ProtoMember(30)]public DateTime SomeDate0 { get; set; }
    [ProtoMember(1)]public DateTime SomeDate1 { get; set; }
    [ProtoMember(2)]public DateTime SomeDate2 { get; set; }
    [ProtoMember(3)]public DateTime SomeDate3 { get; set; }
    [ProtoMember(4)]public DateTime SomeDate4 { get; set; }
    [ProtoMember(5)]public DateTime SomeDate5 { get; set; }
    [ProtoMember(6)]public DateTime SomeDate6 { get; set; }
    [ProtoMember(7)]public DateTime SomeDate7 { get; set; }
    [ProtoMember(8)]public DateTime SomeDate8 { get; set; }
    [ProtoMember(9)]public DateTime SomeDate9 { get; set; }
    [ProtoMember(10)]public string Text0 { get; set; }
    [ProtoMember(11)]public string Text1 { get; set; }
    [ProtoMember(12)]public string Text2 { get; set; }
    [ProtoMember(13)]public string Text3 { get; set; }
    [ProtoMember(14)]public string Text4 { get; set; }
    [ProtoMember(15)]public string Text5 { get; set; }
    [ProtoMember(16)]public string Text6 { get; set; }
    [ProtoMember(17)]public string Text7 { get; set; }
    [ProtoMember(18)]public string Text8 { get; set; }
    [ProtoMember(19)]public string Text9 { get; set; }
    [ProtoMember(20)]public Guid SomeID0 { get; set; }
    [ProtoMember(21)]public Guid SomeID1 { get; set; }
    [ProtoMember(22)]public Guid SomeID2 { get; set; }
    [ProtoMember(23)]public Guid SomeID3 { get; set; }
    [ProtoMember(24)]public Guid SomeID4 { get; set; }
    [ProtoMember(25)]public Guid SomeID5 { get; set; }
    [ProtoMember(26)]public Guid SomeID6 { get; set; }
    [ProtoMember(27)]public Guid SomeID7 { get; set; }
    [ProtoMember(28)]public Guid SomeID8 { get; set; }
    [ProtoMember(29)]public Guid SomeID9 { get; set; }

    public static InternalEntity Generate() => new()
    {
        SomeDate0 = Lorem.DateTime(),
        SomeDate1 = Lorem.DateTime(),
        SomeDate2 = Lorem.DateTime(),
        SomeDate3 = Lorem.DateTime(),
        SomeDate4 = Lorem.DateTime(),
        SomeDate5 = Lorem.DateTime(),
        SomeDate6 = Lorem.DateTime(),
        SomeDate7 = Lorem.DateTime(),
        SomeDate8 = Lorem.DateTime(),
        SomeDate9 = Lorem.DateTime(),
        Text0 = Lorem.Words(10, 50),
        Text1 = Lorem.Words(10, 50),
        Text2 = Lorem.Words(10, 50),
        Text3 = Lorem.Words(10, 50),
        Text4 = Lorem.Words(10, 50),
        Text5 = Lorem.Words(10, 50),
        Text6 = Lorem.Words(10, 50),
        Text7 = Lorem.Words(10, 50),
        Text8 = Lorem.Words(10, 50),
        Text9 = Lorem.Words(10, 50),
        SomeID0 = Guid.NewGuid(),
        SomeID1 = Guid.NewGuid(),
        SomeID2 = Guid.NewGuid(),
        SomeID3 = Guid.NewGuid(),
        SomeID4 = Guid.NewGuid(),
        SomeID5 = Guid.NewGuid(),
        SomeID6 = Guid.NewGuid(),
        SomeID7 = Guid.NewGuid(),
        SomeID8 = Guid.NewGuid(),
        SomeID9 = Guid.NewGuid()
    };
}
