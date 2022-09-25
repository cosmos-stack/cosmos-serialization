using System;

namespace Cosmos.Test.Serialization.DataContractTest;

[Serializable]
public class NiceModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public NiceType NiceType { get; set; }
    public int Count { get; set; }
    public DateTime CreatedTime { get; set; }
    public bool IsValid { get; set; }

    public static NiceModel Create() => new()
    {
        Id = Guid.NewGuid(),
        Count = new Random().Next(0, 100),
        CreatedTime = new DateTime(2000, 1, 1),
        Name = "apple",
        NiceType = NiceType.Yes
    };
}