using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCrunchToDotCover.Core.DotCover;
using NCrunchToDotCover.Core.NCrunch;

namespace NCrunchToDotCover.Converter
{
    public class CoverageConverter : ICoverageConverter
    {
        private readonly INCrunchCoverageExtractor nCrunchCoverageExtractor;
        private readonly IDotCoverCoverageExtractor dotCoverCoverageExtractor;

        public CoverageConverter(INCrunchCoverageExtractor nCrunchCoverageExtractor, ILineInterpreter lineInterpreter)
        {
            this.nCrunchCoverageExtractor = nCrunchCoverageExtractor;
        }

        public Root Convert()
        {
            var root = new Root();
            var solution = nCrunchCoverageExtractor.ExtractCoverage();
            return root;
        }
    }
}
