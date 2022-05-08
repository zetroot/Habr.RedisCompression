using LoremNET;

namespace Habr.RedisCompression;

public class Model
{
    public DateTime SomeDate0 { get; set; } = Lorem.DateTime();
    public DateTime SomeDate1 { get; set; } = Lorem.DateTime();
    public DateTime SomeDate2 { get; set; } = Lorem.DateTime();
    public DateTime SomeDate3 { get; set; } = Lorem.DateTime();
    public DateTime SomeDate4 { get; set; } = Lorem.DateTime();
    public DateTime SomeDate5 { get; set; } = Lorem.DateTime();
    public DateTime SomeDate6 { get; set; } = Lorem.DateTime();
    public DateTime SomeDate7 { get; set; } = Lorem.DateTime();
    public DateTime SomeDate8 { get; set; } = Lorem.DateTime();
    public DateTime SomeDate9 { get; set; } = Lorem.DateTime();
    public string Text0 { get; set; } = Lorem.Words(10, 50);
    public string Text1 { get; set; } = Lorem.Words(10, 50);
    public string Text2 { get; set; } = Lorem.Words(10, 50);
    public string Text3 { get; set; } = Lorem.Words(10, 50);
    public string Text4 { get; set; } = Lorem.Words(10, 50);
    public string Text5 { get; set; } = Lorem.Words(10, 50);
    public string Text6 { get; set; } = Lorem.Words(10, 50);
    public string Text7 { get; set; } = Lorem.Words(10, 50);
    public string Text8 { get; set; } = Lorem.Words(10, 50);
    public string Text9 { get; set; } = Lorem.Words(10, 50);
    public Guid SomeID0 { get; set; } = Guid.NewGuid();
    public Guid SomeID1 { get; set; } = Guid.NewGuid();
    public Guid SomeID2 { get; set; } = Guid.NewGuid();
    public Guid SomeID3 { get; set; } = Guid.NewGuid();
    public Guid SomeID4 { get; set; } = Guid.NewGuid();
    public Guid SomeID5 { get; set; } = Guid.NewGuid();
    public Guid SomeID6 { get; set; } = Guid.NewGuid();
    public Guid SomeID7 { get; set; } = Guid.NewGuid();
    public Guid SomeID8 { get; set; } = Guid.NewGuid();
    public Guid SomeID9 { get; set; } = Guid.NewGuid();
}
