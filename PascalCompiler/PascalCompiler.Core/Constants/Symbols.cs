namespace PascalCompiler.Core.Constants
{
    /// <summary>
    /// Коды символов
    /// </summary>
    public static class Symbols
    {
        /// <summary>
        /// '*'   
        /// </summary>
        public const int Star = 21;

        /// <summary>
        /// '/'   
        /// </summary>
        public const int Slash = 60;

        /// <summary>
        /// '='   
        /// </summary>
        public const int Equal = 16;

        /// <summary>
        /// ','   
        /// </summary>
        public const int Comma = 20;

        /// <summary>
        /// ';'   
        /// </summary>
        public const int Semicolon = 14;

        /// <summary>
        /// ':'   
        /// </summary>
        public const int Colon = 5;

        /// <summary>
        /// '.'   
        /// </summary>
        public const int Point = 61;

        /// <summary>
        /// '^'    
        /// </summary>
        public const int Arrow = 62;

        /// <summary>
        /// '('   
        /// </summary>
        public const int Leftpar = 9;

        /// <summary>
        /// ')'   
        /// </summary>
        public const int Rightpar = 4;

        /// <summary>
        /// '['   
        /// </summary>
        public const int Lbracket = 11;

        /// <summary>
        /// ']'   
        /// </summary>
        public const int Rbracket = 12;

        /// <summary>
        /// '{'   
        /// </summary>
        public const int Flpar = 63;

        /// <summary>
        /// '}'   
        /// </summary>
        public const int Frpar = 64;

        /// <summary>
        /// '<'   
        /// </summary>
        public const int Later = 65;

        /// <summary>
        /// '>'   
        /// </summary>
        public const int Greater = 66;

        /// <summary>
        /// '<='  
        /// </summary>
        public const int Laterequal = 67;

        /// <summary>
        /// '>='  
        /// </summary>
        public const int Greaterequal = 68;

        /// <summary>
        /// '<>'  
        /// </summary>
        public const int Latergreater = 69;

        /// <summary>
        /// '+'   
        /// </summary>
        public const int Plus = 70;

        /// <summary>
        /// '-'   
        /// </summary>
        public const int Minus = 71;

        /// <summary>
        /// '(*'  
        /// </summary>
        public const int Lcomment = 72;

        /// <summary>
        /// '*)'  
        /// </summary>
        public const int Rcomment = 73;

        /// <summary>
        /// ':='  
        /// </summary>
        public const int Assign = 51;

        /// <summary>
        /// '..'  
        /// </summary>
        public const int Twopoints = 74;


        /* типы  констант */

        /// <summary>
        /// идентификатор           
        /// </summary>
        public const int Ident = 2;

        /// <summary>
        /// с  плавающей  точкой    
        /// </summary>
        public const int Floatc = 82;

        /// <summary>
        /// с  фиксированной точкой 
        /// </summary>
        public const int Intc = 15;

        /// <summary>
        /// символьная  константа   
        /// </summary>
        public const int Charc = 83;

        /// <summary>
        /// строковая   константа   
        /// </summary>
        public const int Stringc = 84;


        /* вспомогательные константы */

        /// <summary>
        /// код конца файла         
        /// </summary>
        public const int Endoffile = 253;
        /// <summary>
        /// код конца файла         
        /// </summary>
        public const int Endofline = 254;

        /// <summary>
        /// признак конца последовательности целых чисел 
        /// </summary>
        public const int Eolint = 88;

        /// <summary>
        /// _______ Л О Ж Ь _______ 
        /// </summary>
        public const int False = 0;

        /// <summary>
        /// _____ И С Т И Н А _____ 
        /// </summary>
        public const int True = 1;
    }
}
