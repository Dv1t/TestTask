using System.Xml;
using System.Xml.Serialization;

namespace TestTask.DataClasses
{
    public class Hall
    {
        [XmlAttribute]
        public string plan { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}
