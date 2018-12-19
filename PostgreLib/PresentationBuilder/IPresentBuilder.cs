using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreLib
{
    public interface IPresentBuilder
    {
        void addPresentationView(Entity entity);

        void generateInsertables(Entity entity);


        void addCommandForQuery(IQuery query);

       
    }
}
