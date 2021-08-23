using GraphQL.Types;
using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Type
{
    public class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(i => i.Id);
            Field(i => i.Name);
            Field(i => i.Price);
            Field(i => i.Description);
            Field(i => i.MenuId);
        }
    }
}
