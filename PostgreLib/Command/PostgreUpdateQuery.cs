using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreLib
{
    public abstract class PostgreUpdateQuery : PostgreQuery
    {
        protected PostgreUpdateQuery() : base(QueryType.Update)
        {
        }
    }
}
