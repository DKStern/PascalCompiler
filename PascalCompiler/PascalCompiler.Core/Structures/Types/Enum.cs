using PascalCompiler.Core.Constants;
using System.Collections.Generic;

namespace PascalCompiler.Core.Structures.Types
{
    public class Enum : Type
    {
        public List<Symbol> Symbols { get; set; }

        public Enum()
        {
            Code = TypeCode.Enums;
            Symbols = new List<Symbol>();
        }
    }
}
