using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreLib
{
   public class PresentationDirector
    {
        private IPresentBuilder builder;

        public PresentationDirector(IPresentBuilder builder)
        {
            this.builder = builder;
        }

        public void buildPresentable(AvaliableQueries availableQueries) {

            builder.addPresentationView(availableQueries.Entity);
            builder.generateInsertables(availableQueries.Entity);

            foreach (QueryType type in (QueryType[])Enum.GetValues(typeof(QueryType))) {

                

                IQuery query = availableQueries.getQuery(type);
                if (query != null) {
                 
                    builder.addCommandForQuery(query);
                    
                    
                }
            }

        }
    }
}
