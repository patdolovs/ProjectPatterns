using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreLib
{
   public abstract class PostgreQuery : IQuery
    {

        private QueryType type;


        protected PostgreQuery(QueryType type) {

            this.type = type;
        }


        public abstract string BuildQuery(Entity entity);
    

        public QueryType GetType()
        {

            return type;
        }
    }
}
