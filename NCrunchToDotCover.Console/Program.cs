using System.IO;
using System.Xml.Serialization;
using NCrunchToDotCover.Core.DotCover;

namespace NCrunchToDotCover.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var xmlSerializer = new XmlSerializer(typeof(Solution));
var solution = (Solution)xmlSerializer.Deserialize(new StreamReader(@"C:\temp\ncrunch\RawCoverageResults.xml"));
Console.WriteLine(solution.Projects.Count);

solution.IgnoreProjectRule = p => p.Name.StartsWith("Conecta") && !p.Name.Contains("Testes");

Console.WriteLine("Project: {0} - Coverage: {1:000.00}% - Total lines: {2} - Covered lines: {3}", solution.Path, solution.Coverage, solution.TotalLines, solution.CoveredLines);
foreach (var project in solution.CoverableProjects)
{
    Console.WriteLine("Project: {0} - Coverage: {1:000.00}% - Total lines: {2} - Covered lines: {3}", project.Name, project.Coverage, project.TotalLines, project.CoveredLines);
    /*foreach (var sourceFile in project.CoverableSourceFiles)
    {
        Console.WriteLine("\tFile: {0} - Coverage: {1:000.00}%", sourceFile.Name.PadRight(60), sourceFile.Coverage);
    }#1#
}9*/
            var xmlSerializer = new XmlSerializer(typeof(Root));
            var root = (Root)xmlSerializer.Deserialize(new StreamReader(@"C:\temp\All tests from Conecta.xml"));
            System.Console.WriteLine("Coverage: {0:000.00}% - Total lines: {1} - Covered lines: {2}", root.CoveragePercent, root.TotalStatements, root.CoveredStatements);

            /*Console.WriteLine("Project: {0} - Coverage: {1:000.00}% - Total lines: {2} - Covered lines: {3}", root.Path, root.Coverage, root.TotalLines, root.CoveredLines);
            foreach (var project in root.CoverableProjects)
            {
                Console.WriteLine("Project: {0} - Coverage: {1:000.00}% - Total lines: {2} - Covered lines: {3}", project.Name, project.Coverage, project.TotalLines, project.CoveredLines);
                /*foreach (var sourceFile in project.CoverableSourceFiles)
                {
                    Console.WriteLine("\tFile: {0} - Coverage: {1:000.00}%", sourceFile.Name.PadRight(60), sourceFile.Coverage);
                }#1#
            }*/

        }
    }
}
