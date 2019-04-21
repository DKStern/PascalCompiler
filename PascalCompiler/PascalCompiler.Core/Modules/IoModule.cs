using PascalCompiler.Core.Constants;

namespace PascalCompiler.Core.Modules
{
    public class IoModule
    {
        private readonly Context _context;

        /// <summary>
        /// Создания модуля ввода/вывода
        /// </summary>
        /// <param name="context">Контекст</param>
        public IoModule(Context context)
        {
            _context = context;
            _context.Error += ListError;
            ReadNextLine();
        }

        /// <summary>
        /// Считывание новой строки
        /// </summary>
        private void ReadNextLine()
        {
            _context.Line = _context.SourceCodeDispatcher.ReadLine();
            if (_context.Line != null)
                ListCurrentLine();
        }

        /// <summary>
        /// Вывод текущей строки
        /// </summary>
        private void ListCurrentLine()
        {
            _context.SourceCodeDispatcher.WriteLine($" {_context.LineNumber++.ToString().PadLeft(3)}  {_context.Line}");
        }

        /// <summary>
        /// Вывод ошибки
        /// </summary>
        /// <param name="error">Ошибка</param>
        private void ListError(Error error)
        {
            _context.SourceCodeDispatcher.WriteLine($"*{_context.ErrorNumber++.ToString().PadLeft(3, '0')}* {"^".PadLeft(error.Position)}ошибка код {error.Code}");
            _context.SourceCodeDispatcher.WriteLine($"***** {ErrorDescriptions.Get(error.Code)}");
        }

        /// <summary>
        /// Получить следующую литеру
        /// </summary>
        /// <returns>Литера</returns>
        public char PeekNextChar()
        {
            return _context.CharNumber < _context.Line.Length ? _context.Line[_context.CharNumber] : '\n';
        }

        /// <summary>
        /// Получение литеры через одину
        /// </summary>
        /// <returns>Литера</returns>
        public char PeekNextNextChar()
        {
            return _context.CharNumber + 1 < _context.Line.Length ? _context.Line[_context.CharNumber + 1] : '\n';
        }

        /// <summary>
        /// Переход к следующей литере
        /// </summary>
        /// <returns>Литера</returns>
        public char NextChar()
        {
            if (_context.CharNumber != _context.Line.Length)
                _context.Char = _context.Line[_context.CharNumber++];
            else
            {
                ReadNextLine();
                _context.CharNumber = 0;
                _context.Char = _context.Line == null ? '\0' : '\n';
            }
            return _context.Char;
        }
    }
}
