using System.Xml.Serialization;

namespace NCrunchToDotCover.Core.DotCover
{
    /// <remarks />
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Root
    {
        /// <remarks />
        [XmlElement("Project")]
        public RootProject[] Project { get; set; }

        /// <remarks />
        [XmlAttribute]
        public ushort CoveredStatements { get; set; }

        /// <remarks />
        [XmlAttribute]
        public ushort TotalStatements { get; set; }

        /// <remarks />
        [XmlAttribute]
        public byte CoveragePercent { get; set; }

        /// <remarks />
        [XmlAttribute]
        public string ReportType { get; set; }

        /// <remarks />
        [XmlAttribute]
        public string DotCoverVersion { get; set; }
    }
}