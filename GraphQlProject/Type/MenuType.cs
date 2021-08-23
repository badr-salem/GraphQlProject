using GraphQL.Types;
using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Type
{

    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(i => i.Id);
            Field(i => i.Name);
            Field(i => i.ImageUrl);
        }
    }
}
