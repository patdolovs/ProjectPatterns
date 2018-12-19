using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgreLib
{
  public abstract class AvaliableQueries
    {

        private Entity entity;

        public Entity Entity { get { return entity; } }

        Dictionary<QueryType, IQuery> queries = new Dictionary<QueryType, IQuery>();
        public AvaliableQueries(Entity entity)
        {
            this.entity = entity;
        }

        public void registerQueries(IQuery query) {


            if (!queries.ContainsKey(query.GetType()))
            {
                queries.Add(query.GetType(), query);

            }
            else { MessageBox.Show("Already exists!"); }
        }

        public IQuery getQuery(QueryType type) {


            if (queries.ContainsKey(type)) return queries[type];

            else return null;
            
        }

    

    }
}
