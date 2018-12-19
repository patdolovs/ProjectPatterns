using PostgreLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjekt
{
   public class AvailableItemQueries : AvailablePostgresQueries

    {
        public AvailableItemQueries(PostgreEntity entity) : base(entity)
        {
        }
    }
}
