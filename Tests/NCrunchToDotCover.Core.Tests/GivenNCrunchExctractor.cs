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
            var solutionExtractor = new NCrunchExtractor(@"NCrunchCoverage.xml");
            var coverage = solutionExtractor.ExtractCoverage();
            Assert.IsNotNull(coverage);
        }
    }
}