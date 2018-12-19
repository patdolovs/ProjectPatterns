using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreLib
{
    public abstract class PostgreDeleteQuery : PostgreQuery
    {
        protected PostgreDeleteQuery() : base(QueryType.Delete)
        {
        }
    }
}
