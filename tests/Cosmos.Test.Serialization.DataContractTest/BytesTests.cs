using System;
using Cosmos.Collections;
using Cosmos.Serialization.DataContract;

namespace Cosmos.Test.Serialization.DataContractTest;

public class BytesTests
{
    [Fact]
    public void GenericTypeBytesTest()
    {
        var model = NiceModel.Create();
        var bytes = model.ToDataContractBytes();
        var backs = bytes.FromDataContractBytes<NiceModel>();
        Assert.Equal(
            Tuple.Create(model.Id, model.Name, model.NiceType, model.Count, model.CreatedTime, model.IsValid),
            Tuple.Create(backs.Id, backs.Name, backs.NiceType, backs.Count, backs.CreatedTime, backs.IsValid));
    }

    [Fact]
    public void GenericTypeBytesNullTest()
    {
        NiceModel nullModel = null;
        byte[] nullBytes = null;
        Assert.Null(nullModel.ToDataContractBytes().FromDataContractBytes<NiceModel>());
        Assert.Null(Arrays.Empty<byte>().FromDataContractBytes<NiceModel>());
        Assert.Null(nullBytes.FromDataContractBytes<NiceModel>());
    }

    [Fact]
    public void NonGenericTypeBytesTest()
    {
        object model = NiceModel.Create();
        var bytes = model.ToDataContractBytes(typeof(NiceModel));
        var backs = (NiceModel)bytes.FromDataContractBytes(typeof(NiceModel));
        Assert.Equal(
            Tuple.Create(((NiceModel)model).Id, ((NiceModel)model).Name, ((NiceModel)model).NiceType, ((NiceModel)model).Count, ((NiceModel)model).CreatedTime, ((NiceModel)model).IsValid),
            Tuple.Create(backs.Id, backs.Name, backs.NiceType, backs.Count, backs.CreatedTime, backs.IsValid));
    }

    [Fact]
    public void NonGenericTypeBytesNullTest()
    {
        object nullModel = null;
        byte[] nullBytes = null;
        Assert.Null(nullModel.ToDataContractBytes(typeof(NiceModel)).FromDataContractBytes(typeof(NiceModel)));
        Assert.Null(Arrays.Empty<byte>().FromDataContractBytes(typeof(NiceModel)));
        Assert.Null(nullBytes.FromDataContractBytes(typeof(NiceModel)));
    }
}