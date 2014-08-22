using NCrunchToDotCover.Core.DotCover;
using NUnit.Framework;

namespace NCrunchToDotCover.Core.Tests
{
    [TestFixture]
    public class GivenDotCoverExctractor
    {
        [Test]
        public void CanDeserializedXmlInClass()
        {
            var solutionExtractor = new DotCoverExtractor(@"dotCoverCoverage.xml");
            var coverage = solutionExtractor.ExtractCoverage();
            Assert.IsNotNull(coverage);
        }
    }
}
