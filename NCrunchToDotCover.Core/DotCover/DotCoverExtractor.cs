using System.IO;
using System.Xml.Serialization;

namespace NCrunchToDotCover.Core.DotCover
{
    public class DotCoverExtractor : IDotCoverCoverageExtractor
    {
        private readonly string path;

        public DotCoverExtractor(string path)
        {
            this.path = path;
        }

        public Root ExtractCoverage()
        {
            var xmlSerializer = new XmlSerializer(typeof(Root));
            return (Root)xmlSerializer.Deserialize(new StreamReader(path));
        }
    }
}
