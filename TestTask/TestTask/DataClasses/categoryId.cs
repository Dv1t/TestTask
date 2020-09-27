using System.Xml;
using System.Xml.Serialization;

namespace TestTask.DataClasses
{
    public class categoryId
    {
        [XmlAttribute]
        public string type { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}
