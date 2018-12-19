using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreLib
{
   public abstract class AvailablePostgresQueries : AvaliableQueries
    {
        public AvailablePostgresQueries(PostgreEntity entity) : base(entity)
        {
        }
    }
}
