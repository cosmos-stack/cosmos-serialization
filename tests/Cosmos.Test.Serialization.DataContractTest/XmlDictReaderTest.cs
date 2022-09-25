using System;
using System.IO;
using System.Text;
using System.Xml;
using Cosmos.Serialization.DataContract;

namespace Cosmos.Test.Serialization.DataContractTest;

public class XmlDictReaderTest
{
      [Fact]
    public void XmlDictionaryWriterReaderNonGenericTest()
    {
        var model = NiceModel.Create();
        NiceModel back1;
        using (var fs = new FileStream("XmlWriterReaderNonGenericTest0.xml", FileMode.Create))
        {
            var writer = XmlDictionaryWriter.CreateDictionaryWriter(new XmlTextWriter(fs, Encoding.UTF8));
            writer.WriteDataContractXml(typeof(NiceModel), model);
            writer.Close();
        }

        using (var fs = new FileStream("XmlWriterReaderNonGenericTest0.xml", FileMode.Open))
        {
            var reader = XmlDictionaryReader.CreateDictionaryReader(new XmlTextReader(fs));
            back1 = (NiceModel)reader.ReadDataContractXml(typeof(NiceModel));
            reader.Close();
        }

        NiceModel back2;
        using (var fs = new FileStream("XmlWriterReaderNonGenericTest0.xml", FileMode.Create))
        {
            var writer = XmlDictionaryWriter.CreateDictionaryWriter(new XmlTextWriter(fs, Encoding.UTF8));
            model.DataContractSerialize(typeof(NiceModel), writer);
            writer.Close();
        }

        using (var fs = new FileStream("XmlWriterReaderNonGenericTest0.xml", FileMode.Open))
        {
            var reader = XmlDictionaryReader.CreateDictionaryReader(new XmlTextReader(fs));
            back2 = (NiceModel)reader.ReadDataContractXml(typeof(NiceModel));
            reader.Close();
        }
        Assert.Equal(
            Tuple.Create(model.Id, model.Name, model.NiceType, model.Count, model.CreatedTime, model.IsValid),
            Tuple.Create(back1.Id, back1.Name, back1.NiceType, back1.Count, back1.CreatedTime, back1.IsValid));

        Assert.Equal(
            Tuple.Create(model.Id, model.Name, model.NiceType, model.Count, model.CreatedTime, model.IsValid),
            Tuple.Create(back2.Id, back2.Name, back2.NiceType, back2.Count, back2.CreatedTime, back2.IsValid));
    }

    [Fact]
    public void XmlDictionaryWriterReaderNonGenericNullTest()
    {
        NiceModel testModel = null;
        XmlDictionaryWriter write = null;
        XmlDictionaryReader reader = null;
        testModel.DataContractSerialize(typeof(NiceModel), write);
        write.WriteDataContractXml(typeof(NiceModel), testModel);
        reader.ReadDataContractXml(typeof(NiceModel));
    }
}