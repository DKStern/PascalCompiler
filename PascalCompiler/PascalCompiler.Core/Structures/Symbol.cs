namespace PascalCompiler.Core.Structures
{
    public class Symbol
    {
        public string Name { get; }
        public int Position { get; }

        /// <summary>
        /// Создание символа
        /// </summary>
        /// <param name="value">Значение</param>
        public Symbol(string value)
        {
            Name = value;
        }

        /// <summary>
        /// Создание символа
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="position">Позиция</param>
        public Symbol(string value, int position)
        {
            Name = value;
            Position = position;
        }

        /// <summary>
        /// Получение хэш-кода
        /// </summary>
        /// <returns>Хэш-код</returns>
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
