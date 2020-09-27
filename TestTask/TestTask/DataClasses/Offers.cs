using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace TestTask.DataClasses
{
    public class Offers
    {
        [XmlElement("offer")]
        public List<Offer> offer { get; set; }
    }
}
