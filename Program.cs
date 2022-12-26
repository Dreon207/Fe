namespace Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кафе Сливка");                                      
            string log = "1 - Логин:";
            string parol = "2 - Пароль:";
            string avtoriz = "3 - Авторизация:";
            int kursor = 1;              
            
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();                          
                if (key.Key == ConsoleKey.UpArrow)
                {
                    kursor = kursor - 1; //Вверх переключ
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    kursor = kursor + 1; //Вниз переключ
                }

                // Позиционирование курсора

                if (kursor < 1)
                {
                    kursor = 1;
                }

                if (kursor > 3)
                {
                    kursor = 1;
                }
                //Меню
                Console.Clear();//Проблема
                Console.WriteLine("Введите данные для авторизации в кафе Сливка");
                Console.WriteLine(log);
                Console.WriteLine(parol);
                Console.WriteLine(avtoriz);
                Console.SetCursorPosition(0, kursor);
                Console.WriteLine("->");

                //Выбор места ввода
                if (key.Key == ConsoleKey.Enter)
                {
                    if (kursor == 1)
                    {                     
                        Console.SetCursorPosition(12, kursor);
                    }
                    if (kursor == 2)
                    {
                        Console.SetCursorPosition(13, kursor);
                    }                            
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    if (kursor == 1)
                    {                     
                        Console.SetCursorPosition(12, kursor);
                        string a = Console.ReadLine();
                        if a = Admin.login
                        {

                        }
                    }
                    if (kursor == 2)
                    {
                        Console.SetCursorPosition(13, kursor);
                        string b = Console.ReadLine();
                        if a = Admin.parol
                        {

                        }
                    }                    
                }                
            }

        }
    }
}