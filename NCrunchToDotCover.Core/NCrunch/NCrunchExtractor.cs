using System.IO;
using System.Xml.Serialization;

namespace NCrunchToDotCover.Core.NCrunch
{
    public class NCrunchExtractor : ICoverageExtractor<Solution>
    {
        private readonly string path;

        public NCrunchExtractor(string path)
        {
            this.path = path;
        }

        public Solution ExtractCoverage()
        {
            var xmlSerializer = new XmlSerializer(typeof(Solution));
            return (Solution)xmlSerializer.Deserialize(new StreamReader(path));
        }
    }
}
