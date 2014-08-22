using System.Xml.Serialization;

namespace NCrunchToDotCover.Core.DotCover
{
    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class InternalCompiledMethod
    {
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