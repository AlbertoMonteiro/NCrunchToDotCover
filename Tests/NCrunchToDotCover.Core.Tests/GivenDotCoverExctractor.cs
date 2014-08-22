using System.IO;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NCrunchToDotCover.Core.DotCover;

namespace NCrunchToDotCover.Core.Tests
{
    [TestClass]
    public class GivenDotCoverExctractor
    {
        [TestMethod]
        public void CanDeserializedXmlInClass()
        {
            var xmlSerializer = new XmlSerializer(typeof(Root));
            var root = xmlSerializer.Deserialize(new StreamReader(@"dotCoverCoverage.xml"));
            Assert.IsNotNull(root);
        }
    }
}
