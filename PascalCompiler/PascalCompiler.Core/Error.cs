namespace PascalCompiler.Core
{
    public class Error
    {
        public int Position { get; }
        public int Code { get; }

        public Error(int position, int code)
        {
            Position = position;
            Code = code;
        }
    }
}
