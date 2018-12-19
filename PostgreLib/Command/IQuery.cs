using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreLib
{
    public interface IQuery
    {
        string BuildQuery(Entity entity);

        QueryType GetType();

    }
}
