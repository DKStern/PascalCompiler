using PascalCompiler.Core.Constants;

namespace PascalCompiler.Core.Structures
{
    public class Identifier
    {
        public Symbol Symbol { get; set; }
        public IdentifierClass Class { get; set; }

        public ConstValue ConstValue { get; set; }
        public Type Type { get; set; }

        /// <summary>
        /// Создание идентификатора
        /// </summary>
        public Identifier()
        {
            ConstValue = new ConstValue();
        }

        /// <summary>
        /// Получение хэш-кода
        /// </summary>
        /// <returns>Хэш-код</returns>
        public override int GetHashCode()
        {
            return Symbol.GetHashCode() + Class.GetHashCode();
        }
    }
}
