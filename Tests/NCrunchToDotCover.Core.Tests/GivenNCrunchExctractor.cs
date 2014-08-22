using System.IO;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NCrunchToDotCover.Core.NCrunch;

namespace NCrunchToDotCover.Core.Tests
{
    [TestClass]
    public class GivenNCrunchExctractor
    {
        [TestMethod]
        public void CanDeserializedXmlInClass()
        {
            var xmlSerializer = new XmlSerializer(typeof(Solution));
            var solution = xmlSerializer.Deserialize(new StreamReader(@"NCrunchCoverage.xml"));
            Assert.IsNotNull(solution);
        }
    }
}