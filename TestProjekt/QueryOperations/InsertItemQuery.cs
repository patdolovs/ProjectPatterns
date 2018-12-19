using PostgreLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjekt
{
    public class InsertItemQuery : PostgreInsertQuery
    {
        //fix the names
        
        public override string BuildQuery(Entity entity)
        {
            string queryString = "insert into " + entity.name + "(";

            queryString += string.Join(",", entity.entityValues.Select(v => v.Key));

            queryString += ") values(";

            queryString += string.Join(",", entity.entityValues.Select(v => $"'{v.Value}'"));
            queryString += ")";



            return queryString;
        }
    }
}
