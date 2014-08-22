namespace NCrunchToDotCover.Core
{
    public interface ICoverageExtractor<out T>
    {
        T ExtractCoverage();
    }
}