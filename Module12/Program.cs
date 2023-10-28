using System.Collections;

namespace Module12
{
    internal class Program
    {
        static void Main()
        {
            foreach (User user in UsersStore.GetUsers())
            {
                Console.WriteLine ($"Здравствуйте, {user.Name}!");
                
                if (!user.IsPremium)
                {
                    Advertisement.ShowAds(); //Показываем рекламный блок
                }
                
                Console.WriteLine(); //Строка-разделить
            }
            
            Console.WriteLine("Нажмите любую кнопку для выхода");
            Console.ReadKey();
        }
    }
}