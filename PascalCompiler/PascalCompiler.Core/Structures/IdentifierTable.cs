using PascalCompiler.Core.Constants;
using System.Collections.Generic;
using System.Linq;

namespace PascalCompiler.Core.Structures
{
    public class IdentifierTable
    {
        private HashSet<Identifier> _identifiers;

        /// <summary>
        /// Создание таблицы идентификаторов
        /// </summary>
        public IdentifierTable()
        {
            _identifiers = new HashSet<Identifier>();
        }

        /// <summary>
        /// Добавить идентификатор
        /// </summary>
        /// <param name="symbol">Символ</param>
        /// <param name="classUsed">Класс</param>
        /// <returns>Идентификатор</returns>
        public Identifier Add(Symbol symbol, IdentifierClass classUsed)
        {
            var identifier = new Identifier
            {
                Symbol = symbol,
                Class = classUsed
            };

            return _identifiers.Add(identifier) ? identifier : null;
        }

        /// <summary>
        /// Добавление идентификатора, если его нет
        /// </summary>
        /// <param name="identifier">Идентификатор</param>
        /// <returns>Успешно?</returns>
        public bool ExperimentalAdd(Identifier identifier)
        {
            if (_identifiers.FirstOrDefault(x => x.Symbol.Name == identifier.Symbol.Name) != null)
                return false;
            return _identifiers.Add(identifier);
        }

        /// <summary>
        /// Добавление идентификатора, если его нет
        /// </summary>
        /// <param name="identifier">Идентификатор</param>
        /// <returns>Успешно?</returns>
        public bool Add(Identifier identifier)
        {
            if (_identifiers.FirstOrDefault(x => x.Symbol == identifier.Symbol) != null)
                return false;
            return _identifiers.Add(identifier);
        }

        /// <summary>
        /// Добавление идентификатора, если его нет
        /// </summary>
        /// <param name="identifier">Идентификатор</param>
        /// <returns>Успешно?</returns>
        public bool AddType(Identifier identifier)
        {
            if (_identifiers.FirstOrDefault(x => x.Symbol.Name == identifier.Symbol.Name) != null)
                return false;
            return _identifiers.Add(identifier);
        }

        /// <summary>
        /// Поиск идентификатора
        /// </summary>
        /// <param name="symbol">Символ</param>
        /// <param name="classes">Класс</param>
        /// <returns>Идентификатор</returns>
        public Identifier Search(Symbol symbol, List<IdentifierClass> classes)
        {
            return _identifiers.FirstOrDefault(x => x.Symbol == symbol);
        }

        /// <summary>
        /// Поиск идентификатора
        /// </summary>
        /// <param name="symbolName">Имя символа</param>
        /// <returns>Идентификатор</returns>
        public Identifier Search(string symbolName)
        {
            return _identifiers.FirstOrDefault(x => x.Symbol.Name == symbolName);
        }
    }
}
