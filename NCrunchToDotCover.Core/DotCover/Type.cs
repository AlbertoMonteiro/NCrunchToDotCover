using System.Xml.Serialization;

namespace NCrunchToDotCover.Core.DotCover
{
    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class Type
    {
        /// <remarks />
        [XmlElement("Constructor", typeof (Constructor)),
         XmlElement("Event", typeof (Event)),
         XmlElement("Method", typeof (Method)),
         XmlElement("Property", typeof (Property)),
         XmlElement("Type", typeof(Type))]
        public object[] Items { get; set; }

        /// <remarks />
        [XmlAttribute]
        public string Name { get; set; }

        /// <remarks />
        [XmlAttribute]
        public byte CoveredStatements { get; set; }

        /// <remarks />
        [XmlAttribute]
        public ushort TotalStatements { get; set; }

        /// <remarks />
        [XmlAttribute]
        public byte CoveragePercent { get; set; }
    }
}