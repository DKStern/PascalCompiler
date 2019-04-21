using PascalCompiler.Core;

namespace PascalCompiler.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var compiler = new Compiler(new SourceCodeDispatcher("../../Test/input.txt", "../../Test/listing.txt"));
            compiler.Start();
        }
    }
}
