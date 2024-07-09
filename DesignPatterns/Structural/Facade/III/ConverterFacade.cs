namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Facade.III
{
    internal class ConverterFacade : IJsonConverter, IXmlConverter, IByteArrayConverter
    {
        IJsonConverter _json;
        IXmlConverter _xml;
        IByteArrayConverter _byteArray;

        public ConverterFacade(IJsonConverter json, IXmlConverter xml, IByteArrayConverter byteArray)
        {
            _json = json;
            _xml = xml;
            _byteArray = byteArray;
        }

        public byte[] ToByteArray<T>(T obj)
        {
            return _byteArray.ToByteArray(obj);
        }

        public string ToJson<T>(T obj)
        {
            return _json.ToJson(obj);
        }

        public string ToXml<T>(T obj)
        {
            return _xml.ToXml(obj);
        }
    }
}
