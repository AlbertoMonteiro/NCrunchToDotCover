using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace NCrunchToDotCover.Core.NCrunch
{
    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class Project
    {
        /// <remarks />
        [XmlElement("sourceFile")]
        public List<SourceFile> SourceFiles { get; set; }

        /// <remarks />
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks />
        [XmlAttribute("path")]
        public string Path { get; set; }

        public IEnumerable<SourceFile> CoverableSourceFiles
        {
            get
            {
                return SourceFiles.Where(s => !s.Name.Contains("AssemblyInfo.cs"));
            }
        }

        public double Coverage
        {
            get { return TotalLines == 0 ? 0 : (CoveredLines * 100d) / TotalLines; }
        }

        public int TotalLines
        {
            get { return CoverableSourceFiles.Sum(x => x.TotalLines); }
        }

        public double CoveredLines
        {
            get { return CoverableSourceFiles.Sum(x => x.CoveredLines.Count()); }
        }
    }
}