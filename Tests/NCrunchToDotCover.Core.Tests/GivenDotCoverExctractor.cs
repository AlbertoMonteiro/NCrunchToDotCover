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
            var solutionExtractor = new DotCoverExtractor(@"dotCoverCoverage.xml");
            var coverage = solutionExtractor.ExtractCoverage();
            Assert.IsNotNull(coverage);
        }
    }
}
