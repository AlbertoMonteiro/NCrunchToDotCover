using System.Text.RegularExpressions;

namespace NCrunchToDotCover.Converter
{
    public class LineInterpreter : ILineInterpreter
    {
        public LineInformation DiscoverLineKind(string lineCode)
        {
            var lineInformation = new LineInformation();

            const string ACCESS_MODIFIER = @"((?<accessModifier>public|protected|private|internal) )?";
            const string PARRAMETERS = @"(?<parrameters>\([\w\s,\[\]<>""=]*\))";
            
            var constructorPattern = string.Format(@"^{0}\w+{1}$", ACCESS_MODIFIER, PARRAMETERS);
            var methodPattern = string.Format(@"^{0}void \w+{1}$", ACCESS_MODIFIER, PARRAMETERS);
            var emptyBlockPattern = @"\{ \}";
            var beginBlockPattern = @"^\s*{(\s?\n?)$";
            var commonLinePattern = @"^\s*.+$";

            if (Regex.IsMatch(lineCode, methodPattern))
            {
                lineInformation.Kind = LineKind.Method;
            }
            else if (Regex.IsMatch(lineCode, constructorPattern))
            {
                lineInformation.Kind = LineKind.Constructor;
            }
            else if (Regex.IsMatch(lineCode, emptyBlockPattern))
            {
                lineInformation.Kind = LineKind.EmptyBlock;
            }
            else if (Regex.IsMatch(lineCode, beginBlockPattern))
            {
                lineInformation.Kind = LineKind.BeginBlock;
            }
            else if (Regex.IsMatch(lineCode, commonLinePattern))
            {
                lineInformation.Kind = LineKind.CommonLine;
            }

            return lineInformation;
        }
    }
}