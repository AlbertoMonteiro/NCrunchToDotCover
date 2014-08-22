using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace NCrunchToDotCover.Core.NCrunch
{
    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class SourceFile
    {
        /// <remarks />
        [XmlElement("line")]
        public List<Line> Lines { get; set; }

        /// <remarks />
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks />
        [XmlAttribute("path")]
        public string Path { get; set; }

        public int TotalLines { get { return Lines.Count; } }
        public IEnumerable<Line> CoveredLines { get { return Lines.Where(l => l.CoveringTests > 0); } }

        public double Coverage
        {
            get { return Lines.Count == 0 ? 0 : (CoveredLines.Count() * 100d) / Lines.Count; }
        }
    }
}