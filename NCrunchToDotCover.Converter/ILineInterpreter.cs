namespace NCrunchToDotCover.Converter
{
    public interface ILineInterpreter
    {
        LineInformation DiscoverLineKind(string lineCode);
    }
}