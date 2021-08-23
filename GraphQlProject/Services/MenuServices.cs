using GraphQlProject.Data;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Services
{
    public class MenuServices : IMenu
    {
        private GraphQlDbContext _context;

        public MenuServices(GraphQlDbContext context)
        {
            _context = context;
        }
        public Menu AddMenu(Menu menu)
        {
            _context.Menus.Add(menu);
            _context.SaveChanges();
            return menu;
        }

        public List<Menu> GetMenus()
        {
            return _context.Menus.ToList();
        }
    }
}
