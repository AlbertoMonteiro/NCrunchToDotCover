using NUnit.Framework;

namespace NCrunchToDotCover.Converter.Test
{
    [TestFixture]
    public class GivenLineInterpreter
    {
        [TestCase("public TodasSolicitacoes(IConectaContext context)")]
        [TestCase("public TodasSolicitacoes(IConectaContext context, string file)")]
        [TestCase("public TodasSolicitacoes(IConectaContext context, string file = \"ola\")")]
        [TestCase("public TodasSolicitacoes(IConectaContext context, string file1)")]
        [TestCase("public TodasSolicitacoes(IConectaContext context, string[] file1)")]
        [TestCase("public TodasSolicitacoes(IConectaContext context, IEnumerable<string> file1)")]
        [TestCase("public TodasSolicitacoes()")]
        [TestCase("private TodasSolicitacoes()")]
        [TestCase("protected TodasSolicitacoes()")]
        [TestCase("internal TodasSolicitacoes()")]
        [TestCase("TodasSolicitacoes()")]
        public void DiscoverThatLineIsContructor(string lineCode)
        {
            var lineInterpreter = new LineInterpreter();
            var lineInformation = lineInterpreter.DiscoverLineKind(lineCode);
            Assert.AreEqual(LineKind.Constructor, lineInformation.Kind);
        }

        [TestCase("public void GetSolicitacoes(IConectaContext context)")]
        [TestCase("public void GetSolicitacoes(IConectaContext context, string file)")]
        [TestCase("public void GetSolicitacoes(IConectaContext context, string file = \"ola\")")]
        [TestCase("public void GetSolicitacoes(IConectaContext context, string file1)")]
        [TestCase("public void GetSolicitacoes(IConectaContext context, string[] file1)")]
        [TestCase("public void GetSolicitacoes(IConectaContext context, IEnumerable<string> file1)")]
        [TestCase("public void GetSolicitacoes()")]
        [TestCase("private void GetSolicitacoes()")]
        [TestCase("protected void GetSolicitacoes()")]
        [TestCase("internal void GetSolicitacoes()")]
        [TestCase("void GetSolicitacoes()")]
        public void DiscoverThatLineIsMethod(string lineCode)
        {
            var lineInterpreter = new LineInterpreter();
            var lineInformation = lineInterpreter.DiscoverLineKind(lineCode);
            Assert.AreEqual(LineKind.Method, lineInformation.Kind);
        }

        [TestCase("{ }")]
        public void DiscoverThatLineIsEmptyBlock(string lineCode)
        {
            var lineInterpreter = new LineInterpreter();
            var lineInformation = lineInterpreter.DiscoverLineKind(lineCode);
            Assert.AreEqual(LineKind.EmptyBlock, lineInformation.Kind);
        }
       
        [TestCase("{")]
        [TestCase("    {")]
        [TestCase(@"    {
")]
        [TestCase("    {")]
        [TestCase("        {")]
        [TestCase("            {")]
        public void DiscoverThatLineIsBeginBlock(string lineCode)
        {
            var lineInterpreter = new LineInterpreter();
            var lineInformation = lineInterpreter.DiscoverLineKind(lineCode);
            Assert.AreEqual(LineKind.BeginBlock, lineInformation.Kind);
        }

        [TestCase("            var solicitacoes = context.Solicitacoes.AsQueryable();")]
        [TestCase("var data = filtro.Data;")]
        public void DiscoverThatLineIsCommonLine(string lineCode)
        {
            var lineInterpreter = new LineInterpreter();
            var lineInformation = lineInterpreter.DiscoverLineKind(lineCode);
            Assert.AreEqual(LineKind.CommonLine, lineInformation.Kind);
        }
    }
}