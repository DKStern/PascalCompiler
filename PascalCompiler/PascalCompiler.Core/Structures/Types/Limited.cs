using PascalCompiler.Core.Constants;

namespace PascalCompiler.Core.Structures.Types
{
    public class Limited : Type
    {
        public Type BaseType { get; set; }
        public ConstValue Min { get; set; }
        public ConstValue Max { get; set; }

        public Limited()
        {
            Code = TypeCode.Limiteds;
        }
    }
}
