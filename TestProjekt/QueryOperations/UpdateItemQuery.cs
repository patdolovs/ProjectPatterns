using PostgreLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjekt
{
   public class UpdateItemQuery : PostgreUpdateQuery
    {
        public override string BuildQuery(Entity entity)
        {
            string queryString = "update " + entity.name + " set "+
            string.Join(", ", entity.entityValues.Select(v => $"{v.Key} = '{v.Value}'"));
   
            queryString += $" where {entity.entityValues[0].Key}='{entity.entityValues[0].Value}'";


            return queryString;
        }
    }
}
