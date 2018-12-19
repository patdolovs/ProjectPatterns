using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreLib
{
    public abstract class PostgreInsertQuery : PostgreQuery
    {
        protected PostgreInsertQuery() : base(QueryType.Insert)
        {
           
        }

        public override abstract string BuildQuery(Entity entity);
       
    }
}
