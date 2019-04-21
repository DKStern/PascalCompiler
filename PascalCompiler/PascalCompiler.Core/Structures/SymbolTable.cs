using System.Collections.Generic;

namespace PascalCompiler.Core.Structures
{
    public class SymbolTable
    {
        private Dictionary<string, Symbol> _symbols;
        private List<Symbol> _experimentalSymbols;

        /// <summary>
        /// Создание таблицы символов
        /// </summary>
        public SymbolTable()
        {
            _symbols = new Dictionary<string, Symbol>();
            _experimentalSymbols = new List<Symbol>();
        }

        /// <summary>
        /// Получение символа
        /// </summary>
        /// <param name="name">Имя символа</param>
        /// <returns>Символ</returns>
        public Symbol this[string name]
        {
            get => _symbols[name];
        }

        /// <summary>
        /// Добавление символа
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="position">Позиция</param>
        /// <returns>Символ</returns>
        public Symbol ExperimentalAdd(string name, int position)
        {
            var symbol = new Symbol(name, position);
            _experimentalSymbols.Add(symbol);
            return symbol;
        }

        /// <summary>
        /// Добавление символа
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="position">Позиция</param>
        /// <returns>Символ</returns>
        public Symbol Add(string name, int position)
        {
            if (_symbols.ContainsKey(name))
                return _symbols[name];
            var symbol = new Symbol(name, position);
            _symbols[name] = symbol;
            return symbol;
        }

        /// <summary>
        /// Добавление символа
        /// </summary>
        /// <param name="symbol">Символ</param>
        /// <returns>Успешно?</returns>
        public bool Add(Symbol symbol)
        {
            if (_symbols.ContainsKey(symbol.Name))
                return false;
            _symbols[symbol.Name] = symbol;
            return true;
        }
    }
}
