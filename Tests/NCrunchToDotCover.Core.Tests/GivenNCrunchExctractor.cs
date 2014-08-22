using NCrunchToDotCover.Core.NCrunch;
using NUnit.Framework;

namespace NCrunchToDotCover.Core.Tests
{
    [TestFixture]
    public class GivenNCrunchExctractor
    {
        [Test]
        public void CanDeserializedXmlInClass()
        {
            var solutionExtractor = new NCrunchExtractor(@"NCrunchCoverage.xml");
            var coverage = solutionExtractor.ExtractCoverage();
            Assert.IsNotNull(coverage);
        }
    }
}