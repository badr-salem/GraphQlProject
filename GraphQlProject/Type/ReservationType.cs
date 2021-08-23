using GraphQL.Types;
using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Type
{

    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(i => i.Id);
            Field(i => i.Name);
            Field(i => i.Email);
            Field(i => i.Phone);
            Field(i => i.TotalPeople);
            Field(i => i.Date);
            Field(i => i.Time);
        }
    }
}
