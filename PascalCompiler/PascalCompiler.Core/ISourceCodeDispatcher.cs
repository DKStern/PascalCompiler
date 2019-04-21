namespace PascalCompiler.Core
{
    public interface ISourceCodeDispatcher
    {
        bool IsEnd { get; }
        void WriteLine(string line);
        string ReadLine();
        void Close();
    }
}
