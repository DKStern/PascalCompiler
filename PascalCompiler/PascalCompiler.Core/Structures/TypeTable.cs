using PascalCompiler.Core.Constants;
using PascalCompiler.Core.Structures.Types;
using System.Collections.Generic;

namespace PascalCompiler.Core.Structures
{
    public class TypeTable
    {
        private List<Type> _types;

        /// <summary>
        /// Создание таблицы типов
        /// </summary>
        public TypeTable()
        {
            _types = new List<Type>();
        }

        /// <summary>
        /// Добавление типа
        /// </summary>
        /// <param name="type"></param>
        public void Add(Type type)
        {
            _types.Add(type);
        }

        /// <summary>
        /// Добавление типа
        /// </summary>
        /// <param name="typeCode">Код типа</param>
        /// <returns>Тип</returns>
        public Type Add(TypeCode typeCode)
        {
            Type type = null;
            switch(typeCode)
            {
                case TypeCode.Limiteds:
                    type = new Limited();
                    break;
                case TypeCode.Scalars:
                    type = new Scalar();
                    break;
                case TypeCode.Arrays:
                    type = new Array();
                    break;
                case TypeCode.Enums:
                    type = new Enum();
                    break;
            }
            _types.Add(type);

            return type;
        }
    }
}
