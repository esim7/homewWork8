using DataAccess;
using Service;
using System;

namespace FootballTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-RM1NBDJ;Database=Teams;Trusted_Connection=True;";

            int pageSize = 3;
            int pageNumber = 0;
            MiniContext context = new MiniContext(connectionString);
            ViewDB viewer = new ViewDB(context);
            bool isExit = false;
            while (!isExit)
            {
                Console.Clear();
                try
                {
                    viewer.PaginationShow(pageSize, pageNumber);
                }
                catch (ArgumentOutOfRangeException excepton)
                {
                    Console.WriteLine("Ошибка, что продолжить просмотр листай страницу вперед");
                }
                Console.WriteLine("\n\n1. Следущая страница \n2. Предыдущая страница \n3. Выход");
                string action = Console.ReadLine();
                if (action == "1")
                {
                    ++pageNumber;
                }
                else if (action == "2")
                {
                    --pageNumber;
                }
                else if (action == "3")
                {
                    isExit = true;
                }

            }
        }
    }
}
