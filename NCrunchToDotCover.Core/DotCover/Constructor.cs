using System.Xml.Serialization;

namespace NCrunchToDotCover.Core.DotCover
{
    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class Constructor
    {
        /// <remarks />
        public OwnCoverage OwnCoverage { get; set; }

        /// <remarks />
        public AnonymousMethod AnonymousMethod { get; set; }

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