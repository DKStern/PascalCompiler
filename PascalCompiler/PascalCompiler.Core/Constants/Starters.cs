namespace PascalCompiler.Core.Constants
{
    public static class Starters
    {
        /// <summary>
        /// Стартовые символы разделов описаний и раздела операторов
        /// </summary>
        public static readonly int[] Block = new[] 
        {
            Keywords.Constsy,
            Keywords.Typesy,
            Keywords.Varsy,
            Keywords.Beginsy
        };

        /// <summary>
        /// Правая скобка
        /// </summary>
        public static readonly int[] RightPar = new[]
        {
            Symbols.Rightpar,
            Symbols.Eolint
        };

        /// <summary>
        /// Стартовые символы конструкции constant
        /// </summary>
        public static readonly int[] Const = new[] {
            Symbols.Plus,
            Symbols.Minus,
            Symbols.Charc,
            Symbols.Stringc,
            Symbols.Ident,
            Symbols.Intc,
            Symbols.Floatc
        };

        public static readonly int[] ConstPart = new[]
        {
            Keywords.Constsy,
            Keywords.Typesy,
            Keywords.Varsy,
            Keywords.Beginsy,
        };

        public static readonly int[] ConstDeclaration = new[]
        {
            Symbols.Ident
        };

        public static readonly int[] TypePart = new[]
        {
            Keywords.Typesy,
            Keywords.Varsy,
            Keywords.Beginsy,
        };

        public static readonly int[] TypeDeclaration = new[]
        {
            Symbols.Ident
        };

        /// <summary>
        /// Стартовые символы конструкции описания типа
        /// </summary>
        public static readonly int[] Type = new[]
        {
            Keywords.Arraysy,
            Symbols.Plus,
            Symbols.Minus,
            Symbols.Ident,
            Symbols.Leftpar,
            Symbols.Intc,
            Symbols.Floatc,
            Symbols.Charc,
            Symbols.Stringc
        };

        public static readonly int[] SimpleType = new[]
        {
            Symbols.Plus,
            Symbols.Minus,
            Symbols.Ident,
            Symbols.Leftpar,
            Symbols.Intc,
            Symbols.Floatc,
            Symbols.Charc,
            Symbols.Stringc
        };

        public static readonly int[] EnumerationType = new[]
        {
            Symbols.Leftpar
        };

        public static readonly int[] LimitedType = new[]
        {
            Symbols.Plus,
            Symbols.Minus,
            Symbols.Ident,
            Symbols.Intc,
            Symbols.Floatc,
            Symbols.Charc,
            Symbols.Stringc
        };

        public static readonly int[] CompositeType = new[]
        {
            Keywords.Arraysy
        };

        public static readonly int[] ArrayType = new[]
        {
            Keywords.Arraysy
        };

        public static readonly int[] VarPart = new[]
        {
            Keywords.Varsy
        };
        
        public static readonly int[] VarDeclaration = new[]
        {
            Symbols.Ident
        };

        public static readonly int[] CompoundStatement = new[]
        {
            Keywords.Beginsy
        };

        public static readonly int[] Statement = new[]
        {
            Keywords.Beginsy,
            Keywords.Ifsy,
            Keywords.Whilesy,
            Symbols.Ident,
            Symbols.Semicolon
        };

        public static readonly int[] SimpleStatement = new[]
        {
            Symbols.Ident,
            Symbols.Semicolon
        };

        public static readonly int[] AssignmentStatement = new[]
        {
            Symbols.Ident
        };

        public static readonly int[] Variable = new[]
        {
            Symbols.Ident
        };

        public static readonly int[] Expression = new[]
        {
            Symbols.Plus,
            Symbols.Minus,

            Symbols.Ident,
            Symbols.Leftpar,
            Keywords.Notsy,
            Symbols.Intc,
            Symbols.Floatc,
            Symbols.Charc,
            Symbols.Stringc,
            Symbols.Ident,
            Keywords.Nilsy
        };

        public static readonly int[] SimpleExpression = new[]
        {
            Symbols.Plus,
            Symbols.Minus,

            Symbols.Ident,
            Symbols.Leftpar,
            Keywords.Notsy,
            Symbols.Intc,
            Symbols.Floatc,
            Symbols.Charc,
            Symbols.Stringc,
            Symbols.Ident,
            Keywords.Nilsy
        };

        public static readonly int[] Sign = new[]
        {
            Symbols.Plus,
            Symbols.Minus,

            Symbols.Ident
        };

        public static readonly int[] Term = new[]
        {
            Symbols.Ident,
            Symbols.Intc,
            Symbols.Floatc,
            Symbols.Charc,
            Symbols.Stringc,
            Keywords.Nilsy,
            Symbols.Leftpar,
            Keywords.Notsy
        };

        public static readonly int[] Factor = new[]
        {
            Symbols.Ident,
            Symbols.Intc,
            Symbols.Floatc,
            Symbols.Charc,
            Symbols.Stringc,
            Keywords.Nilsy,
            Symbols.Leftpar,
            Keywords.Notsy
        };

        public static readonly int[] MultiplicativeOperation = new[]
        {
            Symbols.Star,
            Symbols.Slash,
            Keywords.Divsy,
            Keywords.Modsy,
            Keywords.Andsy,
        };

        public static readonly int[] AdditiveOperation = new[]
        {
            Symbols.Plus,
            Symbols.Minus,
            Keywords.Orsy
        };

        public static readonly int[] ComplexStatement = new[]
        {
            Keywords.Beginsy,
            Keywords.Ifsy,
            Keywords.Whilesy,
        };

        public static readonly int[] ConditionalStatement = new[]
        {
            Keywords.Ifsy,
        };

        public static readonly int[] WhileStatement = new[]
        {
            Keywords.Whilesy,
        };

    }
}
