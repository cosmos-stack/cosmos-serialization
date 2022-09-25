using System;
using System.IO;
using Cosmos.Serialization.DataContract;

namespace Cosmos.Test.Serialization.DataContractTest;

public class StreamTest
{
    [Fact]
    public void GenericTypeStreamTest()
    {
        var model = NiceModel.Create();

        var stream0 = model.ToDataContractStream();
        var back1 = stream0.FromDataContractStream<NiceModel>();

        var stream1 = new MemoryStream();
        model.DataContractPackTo(stream1);
        var back2 = stream1.FromDataContractStream<NiceModel>();

        var stream2 = new MemoryStream();
        stream2.DataContractPackBy(model);
        var back3 = stream2.FromDataContractStream<NiceModel>();

        Assert.Equal(
            Tuple.Create(model.Id, model.Name, model.NiceType, model.Count, model.CreatedTime, model.IsValid),
            Tuple.Create(back2.Id, back2.Name, back2.NiceType, back2.Count, back2.CreatedTime, back2.IsValid));

        Assert.Equal(
            Tuple.Create(model.Id, model.Name, model.NiceType, model.Count, model.CreatedTime, model.IsValid),
            Tuple.Create(back2.Id, back2.Name, back2.NiceType, back2.Count, back2.CreatedTime, back2.IsValid));

        Assert.Equal(
            Tuple.Create(model.Id, model.Name, model.NiceType, model.Count, model.CreatedTime, model.IsValid),
            Tuple.Create(back3.Id, back3.Name, back3.NiceType, back3.Count, back3.CreatedTime, back3.IsValid));
    }

    [Fact]
    public void GenericTypeStreamNullTest()
    {
        NiceModel model = null;

        var emptyStream = model.ToDataContractStream();
        Assert.Null(emptyStream.FromDataContractStream<NiceModel>());

        MemoryStream nullStream = null;
        nullStream.DataContractPackBy(model);
        model.DataContractPackTo(nullStream);

        Stream.Null.FromDataContractStream<NiceModel>();
    }

    [Fact]
    public void NonGenericTypeStreamTest()
    {
        object model = NiceModel.Create();

        var stream0 = model.ToDataContractStream(typeof(NiceModel));
        var back1 = (NiceModel)stream0.FromDataContractStream(typeof(NiceModel))!;

        var stream1 = new MemoryStream();
        model.DataContractPackTo(typeof(NiceModel), stream1);
        var back2 = (NiceModel)stream1.FromDataContractStream(typeof(NiceModel))!;

        var stream2 = new MemoryStream();
        stream2.DataContractPackBy(typeof(NiceModel), model);
        var back3 = (NiceModel)stream2.FromDataContractStream(typeof(NiceModel))!;

        Assert.Equal(
            Tuple.Create(((NiceModel)model).Id, ((NiceModel)model).Name, ((NiceModel)model).NiceType, ((NiceModel)model).Count, ((NiceModel)model).CreatedTime, ((NiceModel)model).IsValid),
            Tuple.Create(back2.Id, back2.Name, back2.NiceType, back2.Count, back2.CreatedTime, back2.IsValid));

        Assert.Equal(
            Tuple.Create(((NiceModel)model).Id, ((NiceModel)model).Name, ((NiceModel)model).NiceType, ((NiceModel)model).Count, ((NiceModel)model).CreatedTime, ((NiceModel)model).IsValid),
            Tuple.Create(back2.Id, back2.Name, back2.NiceType, back2.Count, back2.CreatedTime, back2.IsValid));

        Assert.Equal(
            Tuple.Create(((NiceModel)model).Id, ((NiceModel)model).Name, ((NiceModel)model).NiceType, ((NiceModel)model).Count, ((NiceModel)model).CreatedTime, ((NiceModel)model).IsValid),
            Tuple.Create(back3.Id, back3.Name, back3.NiceType, back3.Count, back3.CreatedTime, back3.IsValid));
    }

    [Fact]
    public void NonGenericTypeStreamNullTest()
    {
        object nullModel = null;

        var emptyStream = nullModel.ToDataContractStream(typeof(NiceModel));
        Assert.Null(emptyStream.FromDataContractStream(typeof(NiceModel)));

        MemoryStream nullStream = null;
        nullStream.DataContractPackBy(typeof(NiceModel), nullModel);
        nullModel.DataContractPackTo(typeof(NiceModel), nullStream);

        Stream.Null.FromDataContractStream(typeof(NiceModel));
    }
}