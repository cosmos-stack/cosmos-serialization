using System;
using Cosmos.Serialization.Newtonsoft;
using Newtonsoft.Json;
using Xunit;

namespace Cosmos.Test.Serialization.NewtonsoftTest;

public class JsonTest
{
    [Fact]
    public void BasicJsonTest()
    {
        var model = CreateNiceModel();
        var json1 = model.ToNewtonsoftJson();
        var back1 = json1.FromNewtonsoftJson<NiceModel>();
        var back2 = (NiceModel)json1.FromNewtonsoftJson(typeof(NiceModel));

        Assert.Equal(
            Tuple.Create(model.Id, model.Name, model.NiceType, model.Count, model.CreatedTime, model.IsValid),
            Tuple.Create(back1.Id, back1.Name, back1.NiceType, back1.Count, back1.CreatedTime, back1.IsValid));

        Assert.Equal(
            Tuple.Create(model.Id, model.Name, model.NiceType, model.Count, model.CreatedTime, model.IsValid),
            Tuple.Create(back2.Id, back2.Name, back2.NiceType, back2.Count, back2.CreatedTime, back2.IsValid));
    }

    [Fact]
    public void OptionalJsonTest()
    {
        var model = CreateNiceModel();

        var options = new JsonSerializerSettings { DateTimeZoneHandling = DateTimeZoneHandling.Utc };

        var json1 = model.ToNewtonsoftJson(options);
        var back1 = json1.FromNewtonsoftJson<NiceModel>(options);
        var back2 = (NiceModel)json1.FromNewtonsoftJson(typeof(NiceModel), options);

        Assert.Equal(
            Tuple.Create(model.Id, model.Name, model.NiceType, model.Count, model.CreatedTime, model.IsValid),
            Tuple.Create(back1.Id, back1.Name, back1.NiceType, back1.Count, back1.CreatedTime, back1.IsValid));

        Assert.Equal(
            Tuple.Create(model.Id, model.Name, model.NiceType, model.Count, model.CreatedTime, model.IsValid),
            Tuple.Create(back2.Id, back2.Name, back2.NiceType, back2.Count, back2.CreatedTime, back2.IsValid));
    }

    private static NiceModel CreateNiceModel()
    {
        return new NiceModel
        {
            Id = Guid.NewGuid(),
            Name = "nice",
            NiceType = NiceType.Yes,
            Count = new Random().Next(0, 100),
            CreatedTime = new DateTime(2019, 10, 1).ToUniversalTime(),
            IsValid = true
        };
    }
}