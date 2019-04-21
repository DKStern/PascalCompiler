using PascalCompiler.Core.Constants;
using System.Collections.Generic;

namespace PascalCompiler.Core.Structures.Types
{
    public class Array : Type
    {
        public Type BaseType { get; set; }
        public List<Type> Indexes { get; set; }

        public Array()
        {
            Code = TypeCode.Arrays;
            Indexes = new List<Type>();
        }
    }
}
