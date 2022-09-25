using System;
using System.IO;
using System.Text;
using System.Xml;
using Cosmos.Serialization.DataContract;

namespace Cosmos.Test.Serialization.DataContractTest;

public class GenericXmlDictReaderTest
{
       [Fact]
    public void XmlDictionaryWriterReaderTest()
    {
        var model = NiceModel.Create();
        NiceModel back1;
        using (var fs = new FileStream("XmlWriterReaderTest0.xml", FileMode.Create))
        {
            var writer = XmlDictionaryWriter.CreateDictionaryWriter(new XmlTextWriter(fs, Encoding.UTF8));
            writer.WriteDataContractXml(model);
            writer.Close();
        }

        using (var fs = new FileStream("XmlWriterReaderTest0.xml", FileMode.Open))
        {
            var reader = XmlDictionaryReader.CreateDictionaryReader(new XmlTextReader(fs));
            back1 = reader.ReadDataContractXml<NiceModel>();
            reader.Close();
        }

        NiceModel back2;
        using (var fs = new FileStream("XmlWriterReaderTest1.xml", FileMode.Create))
        {
            var writer = XmlDictionaryWriter.CreateDictionaryWriter(new XmlTextWriter(fs, Encoding.UTF8));
            model.DataContractSerialize(writer);
            writer.Close();
        }

        using (var fs = new FileStream("XmlWriterReaderTest1.xml", FileMode.Open))
        {
            var reader = XmlDictionaryReader.CreateDictionaryReader(new XmlTextReader(fs));
            back2 = reader.ReadDataContractXml<NiceModel>();
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
    public void XmlDictionaryWriterReaderNullTest()
    {
        NiceModel testModel = null;
        XmlDictionaryWriter write = null;
        XmlDictionaryReader reader = null;
        testModel.DataContractSerialize(write);
        write.WriteDataContractXml(testModel);
        reader.ReadDataContractXml<NiceModel>();
    }
}