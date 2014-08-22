using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace NCrunchToDotCover.Core.NCrunch
{
    /// <remarks />
    [XmlType(AnonymousType = true)]
    [XmlRoot("solution", Namespace = "", IsNullable = false)]
    public class Solution
    {
        /// <remarks />
        [XmlElement("project")]
        public List<Project> Projects { get; set; }

        /// <remarks />
        [XmlAttribute("path")]
        public string Path { get; set; }

        [XmlIgnore]
        public IEnumerable<Project> CoverableProjects
        {
            get
            {
                return IgnoreProjectRule != null ? Projects.Where(p => IgnoreProjectRule(p)) : Projects;
            }
        }

        [XmlIgnore]
        public double Coverage
        {
            get { return TotalLines == 0d ? 0 : (CoveredLines * 100d) / TotalLines; }
        }

        [XmlIgnore]
        public double TotalLines
        {
            get { return CoverableProjects.Sum(x => x.TotalLines); }
        }

        [XmlIgnore]
        public double CoveredLines
        {
            get { return CoverableProjects.Sum(x => x.CoveredLines); }
        }

        [XmlIgnore]
        public Predicate<Project> IgnoreProjectRule { get; set; }
    }
}