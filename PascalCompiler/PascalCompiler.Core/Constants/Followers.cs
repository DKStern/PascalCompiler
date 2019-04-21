namespace PascalCompiler.Core.Constants
{
    public static class Followers
    {
        /// <summary>
        /// Символы следующие за конструкцией блока в основной программе
        /// </summary>
        public static readonly int[] Block = new[]
        {
            Symbols.Point
        };

        public static readonly int[] ConstPart = new[]
        {
            Keywords.Typesy,
            Keywords.Varsy,
            Keywords.Beginsy
        };

        public static readonly int[] ConstDeclaration = new[]
        {
            Symbols.Semicolon
        };

        public static readonly int[] TypePart = new[]
        {
            Keywords.Varsy,
            Keywords.Beginsy
        };

        public static readonly int[] TypeDeclaration = new[]
        {
            Symbols.Semicolon
        };

        public static readonly int[] VarPart = new[]
        {
            Keywords.Beginsy
        };

        public static readonly int[] LimitedTypeFirstConst = new[]
        {
            Symbols.Twopoints
        };

        public static readonly int[] SimpleType = new[]
        {
            Symbols.Comma,
            Symbols.Rbracket
        };

        public static readonly int[] VarDeclaration = new[]
        {
            Symbols.Semicolon
        };

        public static readonly int[] Statement = new[]
        {
            Symbols.Semicolon,
            Keywords.Endsy
        };

        public static readonly int[] AssignmentStatementVariable = new[]
        {
            Symbols.Assign
        };

        public static readonly int[] VariableExpression = new[]
        {
            Symbols.Comma,
            Symbols.Rbracket
        };

        public static readonly int[] ExpressionSimpleExpression = new[]
        {
            Symbols.Equal,
            Symbols.Latergreater,
            Symbols.Later,
            Symbols.Laterequal,
            Symbols.Greater,
            Symbols.Greaterequal,
        };

        public static readonly int[] SimpleExpressionSign = new[]
        {
            Symbols.Ident,
            Symbols.Intc,
            Symbols.Floatc,
            Symbols.Charc,
            Symbols.Stringc,
            Keywords.Nilsy,
            Symbols.Leftpar
        };

        public static readonly int[] SimpleExpressionAddend = new[]
        {
            Symbols.Plus,
            Symbols.Minus,
            Keywords.Orsy
        };

        public static readonly int[] AddendMultiplier = new[]
        {
            Symbols.Star,
            Symbols.Slash,
            Keywords.Divsy,
            Keywords.Modsy,
            Keywords.Andsy,
        };

        public static readonly int[] FactorExpression = new[]
        {
            Symbols.Rightpar
        };

        public static readonly int[] ConditionalStatementExpression = new[]
        {
            Keywords.Thensy
        };

        public static readonly int[] ConditionalStatementStatement = new[]
        {
            Keywords.Elsesy
        };

        public static readonly int[] WhileStatementExpression = new[]
        {
            Keywords.Dosy
        };

        /// <summary>
        /// Символы, ожидаемы сразу после вызова simpletype() во время анализа типа "массив"
        /// </summary>
        public static readonly int[] acodes_simpletype = new[]
        {
            Symbols.Comma,
            Symbols.Rbracket,
            Symbols.Eolint
        };

        /// <summary>
        /// Символы ожидаемые сразу после анализа конструкции fixpart
        /// </summary>
        public static readonly int[] acodes_fixpart = new[]
        {
            Keywords.Casesy,
            Symbols.Rightpar,
            Keywords.Endsy,
            Symbols.Eolint
        };

        /// <summary>
        /// Символы, ожидаемые сразу после анализа списка полей при вызове reestrfields() из casefield()
        /// </summary>
        public static readonly int[] acodes_reestrfields = new[]
        {
            Symbols.Rightpar,
            Keywords.Endsy,
            Symbols.Eolint
        };

        /* ( а при вызове из complextype() ожи-	*/
        /* даемый символ только endsy )				*/

        /// <summary>
        /// Символы, ожидаемые сразу после анализа конструкции type при вызове функции type() из fixpart()
        /// </summary>
        public static readonly int[] acodes_typ = new[] 
        {
            Keywords.Endsy,
            Symbols.Rightpar,
            Symbols.Semicolon,
            Symbols.Eolint
        };

        /// <summary>
        /// Символы, ожидаемые сразу после анализа константы при вызове функции constant() из casefield() и variant()	
        /// </summary>
        public static readonly int[] acodes_2constant = new[] 
        {
            Symbols.Comma,
            Symbols.Colon,
            Symbols.Eolint
        };

        /// <summary>
        /// Коды символов, ожидаемых сразу после анализа константы
        /// </summary>
        public static readonly int[] acodes_3const = new[] 
        {
            Symbols.Twopoints,
            Symbols.Comma,
            Symbols.Rbracket,
            Symbols.Eolint
        };

        /// <summary>
        /// Символы, ожидаемые сразу после списка параметров ( символы functionsy,proceduresy,beginsy уже есть в followers) 
        /// </summary>
        public static readonly int[] acodes_listparam = new[]
        {
            Symbols.Colon,
            Symbols.Semicolon,
            Keywords.Forwardsy,
            Keywords.Constsy,
            Keywords.Varsy,
            Symbols.Eolint
        };

        /// <summary>
        /// Символы, ожидаемые сразу после разбора фактических параметров процедур и функций
        /// </summary>
        public static readonly int[] acodes_factparam = new[] 
        {
            Symbols.Comma,
            Symbols.Rightpar,
            Symbols.Eolint
        };

        /// <summary>
        /// символ, ожидаемый сразу после переменной в операторе присваивания и в операторе for 
        /// </summary>
        public static readonly int[] acodes_assign = new[]
        {
            Symbols.Assign,
            Symbols.Eolint
        };

        /// <summary>
        /// символы, ожидаемые сразу после оператора в составном операторе и после варианта в операторе варианта
        /// </summary>
        public static readonly int[] acodes_compcase = new[]
        {
            Symbols.Semicolon,
            Keywords.Endsy,
            Symbols.Eolint
        };

        /// <summary>
        /// символ, ожидаемый сразу после условного выражения в операторе if
        /// </summary>
        public static readonly int[] acodes_iftrue = new[]
        {
            Keywords.Thensy,
            Symbols.Eolint
        };

        /// <summary>
        /// символ, ожидаемый сразу после оператора ветви "истина" в операторе if
        /// </summary>
        public static readonly int[] acodes_iffalse = new[]
        {
            Keywords.Elsesy,
            Symbols.Eolint
        };

        /// <summary>
        /// символы, ожидаемые сразу после переменной в заголовке оператора with
        /// </summary>
        public static readonly int[] acodes_wiwifor = new[]
        {
            Symbols.Comma,
            Keywords.Dosy,
            Symbols.Eolint
        };

        /// <summary>
        /// символ, ожидаемый сразу после условного выражения в операторе while 
        /// и сразу после выражения-второй границы изменения параметра цикла в операторе for
        /// </summary>
        public static readonly int[] acodes_while = new[]
        {
            Keywords.Dosy,
            Symbols.Eolint
        };

        /// <summary>
        /// cимволы, ожидаемые сразу после оператора в теле оператора repeat
        /// </summary>
        public static readonly int[] acodes_repeat = new[]
        {
            Keywords.Untilsy,
            Symbols.Semicolon,
            Symbols.Eolint
        };

        /// <summary>
        /// символ, ожидаемый сразу после выбирающего выражения в операторе case
        /// </summary>
        public static readonly int[] acodes_case1 = new[]
        {
            Keywords.Ofsy,
            Symbols.Eolint
        };

        /// <summary>
        /// символы, ожидаемые сразу после выражения-первой границы изменения пераметра цикла в операторе for
        /// </summary>
        public static readonly int[] acodes_for1 = new[]
        {
            Keywords.Tosy,
            Keywords.Downtosy,
            Symbols.Eolint
        };

        /// <summary>
        /// после идентификатора в переменной
        /// </summary>
        public static readonly int[] acodes_ident = new[]
        {
            Symbols.Lbracket,
            Symbols.Arrow,
            Symbols.Point,
            Symbols.Eolint
        };

        /// <summary>
        /// после индексного выражения при разборе массива
        /// </summary>
        public static readonly int[] acodes_index = new[] 
        {
            Symbols.Rbracket,
            Symbols.Comma,
            Symbols.Eolint
        };

        /// <summary>
        /// после 1-го выражения в конструкторе множества
        /// </summary>
        public static readonly int[] acodes_set1 = new[] 
        {
            Symbols.Rbracket,
            Symbols.Twopoints,
            Symbols.Comma,
            Symbols.Eolint
        };
    }
}
