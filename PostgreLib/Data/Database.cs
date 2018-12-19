using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreLib
{
   public class Database
    {

        public List<Entity> entities = new List<Entity>();
       // AvaliableQueries availbleQueries;


        public void addEntity(Entity entity) {

            entities.Add(entity);
        }

       
    }
}
