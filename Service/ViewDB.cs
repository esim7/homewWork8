using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Service
{
    public class ViewDB
    {
        public MiniContext DataContext { get; set; }

        public ViewDB(MiniContext context)
        {
            this.DataContext = context;
        }
        public void PaginationShow(int pageSize, int pageNumber)
        {
            if (pageNumber < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            var players = DataContext.Players.Include(p => p.Team).Skip(pageNumber * pageSize).Take(pageSize).ToList();
            foreach (var player in players)
            {
                Console.WriteLine("Имя игрока: " + player.FullName + "\nКоманда в которой выступает игрок: " + player.Team.Name + "\n");
            }

            
        }
    }
}
