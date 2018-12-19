using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreLib
{
   public class Entity
    {
        public string name;
        public string primaryKey { get { return entityValues.ElementAt(0).Key; } }
        public string primaryKeyValue { get { return entityValues.ElementAt(0).Value; } }
       
        public List<KeyValuePair<string, string>> entityValues = new List<KeyValuePair<string, string>>();
        public string foreignKeyValue;
        public string updateIdValue;

        


    }
}
