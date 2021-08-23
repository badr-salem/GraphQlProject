using GraphQlProject.Data;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Services
{
    public class SubMenuServices : ISubMenu
    {
        private GraphQlDbContext _context;

        public SubMenuServices(GraphQlDbContext context)
        {
            _context = context;
        }

        public SubMenu AddSubMenu(SubMenu subMenu)
        {
            _context.SubMenus.Add(subMenu);
            _context.SaveChanges();
            return subMenu;
        }

        public List<SubMenu> GetSubMenus()
        {
            return _context.SubMenus.ToList();
        }

        public List<SubMenu> GetSubMenus(int menuId)
        {
            return _context.SubMenus.Where(i => i.MenuId == menuId).ToList();
        }
    }
}
