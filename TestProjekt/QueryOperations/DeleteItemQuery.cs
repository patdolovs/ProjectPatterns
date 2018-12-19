using PostgreLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjekt
{
    public class DeleteItemQuery : PostgreDeleteQuery
    {
        public override string BuildQuery(Entity entity)
        {
            string queryString = $"delete from {entity.name} where {entity.primaryKey} = '{entity.primaryKeyValue}';";

            return queryString;
        }
    }
}
