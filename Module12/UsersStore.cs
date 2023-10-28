using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12
{
    /// <summary>
    /// Класс реализующий механизмы хранения пользователей
    /// Вынес в отдельный класс. Типа моделирование их получение из DB
    /// </summary>
    internal class UsersStore
    {
        /// <summary>
        /// Статический метод-заглушка получения пользователей (добавление их в список)
        /// </summary>
        /// <returns>Возвращаемое значение - список пользователей (ArrayList)</returns>
        public static ArrayList GetUsers() 
        {
            ArrayList usersList = new();

            usersList.Add(new User("Ivan", "Иван", true));
            usersList.Add(new User("Peter", "Пётр", false));
            usersList.Add(new User("Basil", "Василий", true));
            return usersList;
        }
    }
}
