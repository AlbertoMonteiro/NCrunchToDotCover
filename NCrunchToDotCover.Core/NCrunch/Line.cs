using System.Xml.Serialization;

namespace NCrunchToDotCover.Core.NCrunch
{
    /// <remarks />
    [XmlType(AnonymousType = true)]
    public class Line
    {
        /// <remarks />
        [XmlAttribute("number")]
        public ushort Number { get; set; }

        /// <remarks />
        [XmlAttribute("coveringTests")]
        public ushort CoveringTests { get; set; }
    }
}