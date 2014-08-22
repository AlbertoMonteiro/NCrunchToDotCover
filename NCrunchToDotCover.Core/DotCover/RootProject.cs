using System.Xml.Serialization;

namespace NCrunchToDotCover.Core.DotCover
{
    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class RootProject
    {
        /// <remarks />
        [XmlElement("Namespace")]
        public Namespace[] Namespace { get; set; }

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