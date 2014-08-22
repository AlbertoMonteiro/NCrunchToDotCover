using System.Xml.Serialization;

namespace NCrunchToDotCover.Core.DotCover
{
    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class Property
    {
        /// <remarks />
        public PropertyGetter PropertyGetter { get; set; }

        /// <remarks />
        public PropertySetter PropertySetter { get; set; }

        /// <remarks />
        [XmlAttribute]
        public string Name { get; set; }

        /// <remarks />
        [XmlAttribute]
        public byte CoveredStatements { get; set; }

        /// <remarks />
        [XmlAttribute]
        public byte TotalStatements { get; set; }

        /// <remarks />
        [XmlAttribute]
        public byte CoveragePercent { get; set; }
    }
}