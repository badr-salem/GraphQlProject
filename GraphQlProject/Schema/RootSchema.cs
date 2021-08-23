using GraphQL.Utilities;
using GraphQlProject.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Schema
{
    public class RootSchema : GraphQL.Types.Schema
    {
        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            //Query = serviceProvider.GetRequiredService()
            Query = serviceProvider.GetRequiredService<RootQuery>();
        }
    }
}
