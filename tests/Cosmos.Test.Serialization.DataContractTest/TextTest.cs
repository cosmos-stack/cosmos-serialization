using System;
using Cosmos.Serialization.DataContract;

namespace Cosmos.Test.Serialization.DataContractTest;

public class TextTest
{
    [Fact]
    public void GenericTypeXmlTest()
    {
        var model = NiceModel.Create();
        var json = model.ToDataContractXml();
        var backs = json.FromDataContractXml<NiceModel>();
        Assert.Equal(
            Tuple.Create(model.Id, model.Name, model.NiceType, model.Count, model.CreatedTime, model.IsValid),
            Tuple.Create(backs.Id, backs.Name, backs.NiceType, backs.Count, backs.CreatedTime, backs.IsValid));
    }

    [Fact]
    public void GenericTypeXmlNullTest()
    {
        NiceModel nullModel = null;
        string nullXml = null;
        var emptyXml = nullModel.ToDataContractXml();
        Assert.Null(emptyXml.FromDataContractXml<NiceModel>());
        Assert.Null(nullXml.FromDataContractXml<NiceModel>());
    }

    [Fact]
    public void NonGenericTypeXmlTest()
    {
        object model = NiceModel.Create();
        var json = model.ToDataContractXml(typeof(NiceModel));
        var backs = (NiceModel)json.FromDataContractXml(typeof(NiceModel))!;
        Assert.Equal(
            Tuple.Create(((NiceModel)model).Id, ((NiceModel)model).Name, ((NiceModel)model).NiceType, ((NiceModel)model).Count, ((NiceModel)model).CreatedTime, ((NiceModel)model).IsValid),
            Tuple.Create(backs.Id, backs.Name, backs.NiceType, backs.Count, backs.CreatedTime, backs.IsValid));
    }

    [Fact]
    public void NonGenericTypeXmlNullTest()
    {
        object nullModel = null;
        string nullXml = null;
        var emptyXml = nullModel.ToDataContractXml(typeof(NiceModel));
        Assert.Null(emptyXml.FromDataContractXml(typeof(NiceModel)));
        Assert.Null(nullXml.FromDataContractXml(typeof(NiceModel)));
    }
}