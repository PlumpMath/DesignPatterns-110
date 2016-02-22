using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessPatterns.IdentityMapPattern.Repository
{
    public class IdentityMap<T>
    {
        Hashtable entities = new Hashtable();

        public T GetByID(Guid id)
        {
            if (entities.ContainsKey(id))
            {
                return (T)entities[id];
            }
            else
            {
                return default(T);
            }
        }

        public void Store(T entity, Guid key)
        {
            if (!entities.ContainsKey(key))
            {
                entities.Add(key, entity);
            }
        }
    }
}
