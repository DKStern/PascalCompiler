using PascalCompiler.Core.Constants;
using Symbols = PascalCompiler.Core.Constants.Symbols;

namespace PascalCompiler.Core.Modules
{
    public class LexicalAnalyzerModule
    {
        private const int MaxInt = 32767;
        private const int MaxString = 20;
        private const int MaxName = 15;
        private readonly IoModule _ioModule;
        private readonly Context _context;

        private char _currentChar;

        /// <summary>
        /// Создание модуля лексического анализатора
        /// </summary>
        /// <param name="context">Контекст</param>
        /// <param name="ioModule">Модуль ввода/вывода</param>
        public LexicalAnalyzerModule(Context context, IoModule ioModule)
        {
            _context = context;
            _ioModule = ioModule;
        }

        /// <summary>
        /// Вывод ошибки
        /// </summary>
        /// <param name="errorCode">Код ошибки</param>
        private void ListError(int errorCode)
        {
            var error = new Error(_context.CharNumber, errorCode);
            _context.OnError(error);
        }

        /// <summary>
        /// Чтнение меньше
        /// </summary>
        /// <returns>Код символа</returns>
        private int ScanLater()
        {
            _currentChar = _ioModule.PeekNextChar();
            int symbol;

            if (_currentChar == '=')
            {
                _currentChar = _ioModule.NextChar();
                _context.SymbolName += _currentChar;
                symbol = Symbols.Laterequal;
            }
            else if (_currentChar == '>')
            {
                _currentChar = _ioModule.NextChar();
                _context.SymbolName += _currentChar;
                symbol = Symbols.Latergreater;
            }
            else
            {
                symbol = Symbols.Later;
            }

            return symbol;
        }

        /// <summary>
        /// Чтение Больше
        /// </summary>
        /// <returns>Код символа</returns>
        private int ScanGreater()
        {
            _currentChar = _ioModule.PeekNextChar();
            int symbol;

            if (_currentChar == '=')
            {
                _currentChar = _ioModule.NextChar();
                _context.SymbolName += _currentChar;
                symbol = Symbols.Greaterequal;
            }
            else
            {
                symbol = Symbols.Greater;
            }

            return symbol;
        }

        /// <summary>
        /// Чтение двоеточия
        /// </summary>
        /// <returns>Код символа</returns>
        private int ScanColon()
        {
            _currentChar = _ioModule.PeekNextChar();
            int symbol;

            if (_currentChar == '=')
            {
                _currentChar = _ioModule.NextChar();
                _context.SymbolName += _currentChar;
                symbol = Symbols.Assign;
            }
            else
            {
                symbol = Symbols.Colon;
            }

            return symbol;
        }

        /// <summary>
        /// Чтение точки
        /// </summary>
        /// <returns>Код символа</returns>
        private int ScanPoint()
        {
            _currentChar = _ioModule.PeekNextChar();
            int symbol;

            if (_currentChar == '.')
            {
                _currentChar = _ioModule.NextChar();
                _context.SymbolName += _currentChar;
                symbol = Symbols.Twopoints;
            }
            else
            {
                symbol = Symbols.Point;
            }

            return symbol;
        }

        /// <summary>
        /// Чтение левой скобки
        /// </summary>
        /// <returns>Код символа</returns>
        private int ScanLeftpar()
        {
            _currentChar = _ioModule.PeekNextChar();
            int symbol;

            if (_currentChar == '*')
            {
                // Пропускаем весь комментарий
                var prevChar = _currentChar;
                _currentChar = _ioModule.NextChar();
                while ((prevChar != '*' || _currentChar != ')') && 
                        _currentChar != '\0')
                {
                    prevChar = _currentChar;
                    _currentChar = _ioModule.NextChar();
                }
                if (prevChar == '*' && _currentChar == ')')
                    symbol = NextSymbol();
                else
                {
                    ListError(86);
                    symbol = Symbols.Endoffile;
                }
            }
            else
            {
                symbol = Symbols.Leftpar;
            }

            return symbol;
        }

        /// <summary>
        /// Чтение звезды
        /// </summary>
        /// <returns>Код символа</returns>
        private int ScanStar()
        {
            _currentChar = _ioModule.PeekNextChar();
            int symbol;

            if (_currentChar == ')')
            {
                _currentChar = _ioModule.NextChar();
                _context.SymbolName += _currentChar;
                ListError(85);
                symbol = Symbols.Rcomment;
            }
            else
            {
                symbol = Symbols.Star;
            }

            return symbol;
        }

        /// <summary>
        /// Чтение числовой константы
        /// </summary>
        /// <returns>Код символа</returns>
        private int ScanNumberConstant()
        {
            var integerPart = _currentChar - '0';
            var listIntegerError = false;
            _currentChar = _ioModule.PeekNextChar();
            while (_currentChar >= '0' && _currentChar <= '9')
            {
                _currentChar = _ioModule.NextChar();
                _context.SymbolName += _currentChar;
                var digit = _currentChar - '0';
                if (!listIntegerError && (integerPart < MaxInt / 10 || (integerPart == MaxInt / 10 && digit <= MaxInt % 10)))
                    integerPart = 10 * integerPart + digit;
                else
                    listIntegerError = true;
                _currentChar = _ioModule.PeekNextChar();
            }

            if (_currentChar != '.')
            {
                if (listIntegerError)
                    ListError(203);
                return Symbols.Intc;
            }

            var nextChar = _ioModule.PeekNextNextChar();
            if (nextChar < '0' || nextChar > '9')
                return Symbols.Intc;
            _ioModule.NextChar();
            _context.SymbolName += _currentChar;
            _currentChar = _ioModule.PeekNextChar();

            if (_currentChar < '0' || _currentChar > '9')
            {
                ListError(201);
                return Symbols.Floatc;
            }

            var floatPart = 0;
            var listFloatError = false;
            while (_currentChar >= '0' && _currentChar <= '9')
            {
                _currentChar = _ioModule.NextChar();
                _context.SymbolName += _currentChar;
                var digit = _currentChar - '0';
                if (!listFloatError && (floatPart < MaxInt / 10 || (floatPart == MaxInt / 10 && digit <= MaxInt % 10)))
                    floatPart = 10 * floatPart + digit;
                else
                    listFloatError = true;
                _currentChar = _ioModule.PeekNextChar();
            }

            if (listIntegerError || listFloatError)
                ListError(207);

            return Symbols.Floatc;
        }

        /// <summary>
        /// Чтение строки
        /// </summary>
        /// <returns>Код символа</returns>
        private int ScanString()
        {
            _ioModule.NextChar();
            _context.SymbolName += _context.Char;
            if (_context.Char == '\'' || _context.Char == '\n')
            {
                ListError(75);
                return Symbols.Charc;
            }

            _ioModule.NextChar();
            _context.SymbolName += _context.Char;

            if (_context.Char == '\'')
            {
                _context.SymbolName += _context.Char;
                return Symbols.Charc;
            }

            if (_context.Char == '\n')
            {
                ListError(75);
                return Symbols.Charc;
            }

            _ioModule.NextChar();
            var length = 2;
            var listError = false;
            while (_context.Char != '\'')
            {
                _context.SymbolName += _context.Char;
                if (length++ > MaxString)
                    listError = true;
                _ioModule.NextChar();
                if (_context.Char == '\n')
                {
                    ListError(75);
                    return Symbols.Stringc;
                }
            }
            _context.SymbolName += _context.Char;
            if (listError)
                ListError(76);

            return Symbols.Stringc;
        }

        /// <summary>
        /// Чтение имени
        /// </summary>
        /// <returns>Код символа</returns>
        private int ScanName()
        {
            var nameLength = 1;
            _currentChar = _ioModule.PeekNextChar();
            while ((_currentChar >= 'a' && _currentChar <= 'z' ||
                    _currentChar >= 'A' && _currentChar <= 'Z' ||
                    _currentChar >= '0' && _currentChar <= '9' ||
                    _currentChar == '_') && nameLength <= MaxName)
            {
                _currentChar = _ioModule.NextChar();
                _context.SymbolName += _currentChar;
                nameLength++;
                _currentChar = _ioModule.PeekNextChar();
            }

            int symbol;
            _context.SymbolName = _context.SymbolName.ToLower();
            if (Keywords.ByName.ContainsKey(_context.SymbolName.ToLower()))
            {
                symbol = Keywords.ByName[_context.SymbolName.ToLower()];
            }
            else
            {
                symbol = Symbols.Ident;
                _context.Symbol = _context.SymbolTable.ExperimentalAdd(_context.SymbolName, _context.SymbolPosition);
            }

            return symbol;
        }

        /// <summary>
        /// Чтение левой фигурной скобки
        /// </summary>
        /// <returns>Код символа</returns>
        private int ScanFlpar()
        {
            int symbol;
            _currentChar = _ioModule.NextChar();

            while (_currentChar != '}' && _currentChar != '\0')
                _currentChar = _ioModule.NextChar();

            if (_currentChar == '}')
                symbol = NextSymbol();
            else
            {
                ListError(86);
                symbol = Symbols.Endoffile;
            }

            return symbol;
        }

        /// <summary>
        /// Чтение правой фигурной скобки
        /// </summary>
        /// <returns>Код символа</returns>
        private int ScanFrpar()
        {
            ListError(85);
            return Symbols.Frpar;
        }

        /// <summary>
        /// Чтение следующего символа
        /// </summary>
        /// <returns></returns>
        public int NextSymbol()
        {
            var symbolCode = Symbols.Endoffile;
            _currentChar = _ioModule.NextChar();
            _context.SymbolName = _currentChar.ToString();
            // TODO: табы под вопросом - неправильно отображается позиция ошибки
            while (_currentChar == ' ' || _currentChar == '\t')
            {
                _currentChar = _ioModule.NextChar();
                _context.SymbolName = _currentChar.ToString();
            }
            _context.SymbolPosition = _context.CharNumber;

            switch (_currentChar)
            {
                case '\'':
                    symbolCode = ScanString();
                    break;

                case '<':
                    symbolCode = ScanLater();
                    break;

                case '>':
                    symbolCode = ScanGreater();
                    break;

                case ':':
                    symbolCode = ScanColon();
                    break;

                case '.':
                    symbolCode = ScanPoint();
                    break;

                case '*':
                    symbolCode = ScanStar();
                    break;

                case '(':
                    symbolCode = ScanLeftpar();
                    break;

                case '{':
                    symbolCode = ScanFlpar();
                    break;

                case '}':
                    symbolCode = ScanFrpar();
                    break;

                case ')':
                    symbolCode = Symbols.Rightpar;
                    break;

                case ';':
                    symbolCode = Symbols.Semicolon;
                    break;

                case '/':
                    symbolCode = Symbols.Slash;
                    break;

                case '=':
                    symbolCode = Symbols.Equal;
                    break;

                case ',':
                    symbolCode = Symbols.Comma;
                    break;

                case '^':
                    symbolCode = Symbols.Arrow;
                    break;

                case '[':
                    symbolCode = Symbols.Lbracket;
                    break;

                case ']':
                    symbolCode = Symbols.Rbracket;
                    break;

                case '+':
                    symbolCode = Symbols.Plus;
                    break;

                case '-':
                    symbolCode = Symbols.Minus;
                    break;

                case '\n':
                    symbolCode = Symbols.Endofline;
                    break;

                case '\0':
                    symbolCode = Symbols.Endoffile;
                    break;
                default:
                    if (_currentChar >= '0' && _currentChar <= '9')
                    {
                        symbolCode = ScanNumberConstant();
                    } else if (_currentChar >= 'a' && _currentChar <= 'z' ||
                               _currentChar >= 'A' && _currentChar <= 'Z')
                    {
                        symbolCode = ScanName();
                    }
                    else
                    {
                        ListError(6);
                    }

                    break;
            }

            _context.SymbolCode = symbolCode;
            Logger.LogSymbol(_context.SymbolName);
            if (_context.SymbolCode == Symbols.Endofline)
                return NextSymbol();
            return symbolCode;
        }
    }
}
