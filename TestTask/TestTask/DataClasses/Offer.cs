using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace TestTask.DataClasses
{
    public class Offer
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public string type { get; set; }
        [XmlAttribute]
        public string bid { get; set; }
        [XmlAttribute]
        public string cbid { get; set; }
        [XmlAttribute]
        public string available { get; set; }
        
        [XmlElement("url")]
        public string url { get; set; }

        [XmlElement("price")]
        public string price { get; set; }
        [XmlElement("currencyId")]
        public string currencyId { get; set; }

        [XmlElement("categoryId")]
        public categoryId categoryId { get; set; }
        [XmlElement("picture")]
        public string picture { get; set; }
        [XmlElement("delivery")]
        public string delivery { get; set; }
        [XmlElement("local_delivery_cost")]
        public string local_delivery_cost { get; set; }
        [XmlElement("author")]
        public string author { get; set; }
        [XmlElement("typePrefix")]
        public string typePrefix { get; set; }
        [XmlElement("vendor")]
        public string vendor { get; set; }
        [XmlElement("vendorCode")]
        public string vendorCode { get; set; }
        [XmlElement("model")]
        public string model { get; set; }
        [XmlElement("description")]
        public string description { get; set; }
        [XmlElement("manufacturer_warranty")]
        public string manufacturer_warranty { get; set; }
        [XmlElement("country_of_origin")]
        public string country_of_origin { get; set; }
        [XmlElement("name")]
        public string name { get; set; }
        [XmlElement("publisher")]
        public string publisher { get; set; }
        [XmlElement("series")]
        public string series { get; set; }
        [XmlElement("year")]
        public string year { get; set; }
        [XmlElement("ISBN")]
        public string isbn { get; set; }
        [XmlElement("volume")]
        public string volume { get; set; }
        [XmlElement("part")]
        public string part { get; set; }
        [XmlElement("language")]
        public string language { get; set; }
        [XmlElement("binding")]
        public string binding { get; set; }
        [XmlElement("page_extent")]
        public string page_extent { get; set; }
        [XmlElement("downloadable")]
        public string downloadable { get; set; }
        [XmlElement("performed_by")]
        public string performed_by { get; set; }
        [XmlElement("performance_type")]
        public string performance_type { get; set; }
        [XmlElement("storage")]
        public string storage { get; set; }
        [XmlElement("format")]
        public string format { get; set; }
        [XmlElement("recording_length")]
        public string recording_length { get; set; }
        [XmlElement("media")]
        public string media { get; set; }
        [XmlElement("starring")]
        public string starring { get; set; }
        [XmlElement("director")]
        public string director { get; set; }
        [XmlElement("originalName")]
        public string originalName { get; set; }
        [XmlElement("country")]
        public string country { get; set; }
        [XmlElement("worldRegion")]
        public string worldRegion { get; set; }
        [XmlElement("region")]
        public string region { get; set; }
        [XmlElement("days")]
        public string days { get; set; }
        [XmlElement("dataTour")]
        public List<string> dataTour { get; set; }

        [XmlElement("hotel_stars")]
        public string hotel_stars { get; set; }
        [XmlElement("meal")]
        public string meal { get; set; }
        [XmlElement("included")]
        public string included { get; set; }
        [XmlElement("transport")]
        public string transport { get; set; }
        [XmlElement("place")]
        public string place { get; set; }
        [XmlElement("hall")]
        public Hall hall { get; set; }
        [XmlElement("hall_part")]
        public string hall_part { get; set; }
        [XmlElement("date")]
        public string date { get; set; }
        [XmlElement("is_premiere")]
        public bool is_premiere { get; set; }
        [XmlElement("is_kids")]
        public bool is_kids { get; set; }

        public override string ToString()
        {
            return id;
        }


    }
}
