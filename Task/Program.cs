namespace Homework
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }



    class Program
    {
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            //Остановка 1 секунда
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            //Остановка 2 секунды
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            //Остановка 3 секунды
            Thread.Sleep(3000);
        }

        static void Main(string[] args)
        {
            User user = new User();

            Console.Write("Введите ваше имя : ");
            user.Name = Console.ReadLine();

            Console.Write("Введите ваш логин : ");
            user.Login = Console.ReadLine();

            Console.Write("Есть ли у вас премиум акаунт ? (Да/Нет): ");
            string answer = Console.ReadLine();

            if (answer == "Да" || answer == "да")
            {
                user.IsPremium = true;
            }
            else if (answer == "Нет" || answer == "нет")
            {
                user.IsPremium = false;
            }
            else
            {
                Console.WriteLine("Вы ввели неверный ответ !");
            }

            if (user.IsPremium == false)
            {
                Console.WriteLine($"Привет {user.Name} , ваш логин {user.Login} , у вас нет премиум подписки.");
                ShowAds();
            }
            else
            {
                Console.WriteLine($"Console.WriteLine($\"Привет {user.Name} , ваш логин {user.Login} , у вас есть премиум подписки.\");");
            }
        }
    }

}