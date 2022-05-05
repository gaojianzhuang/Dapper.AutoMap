using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.AutoMap
{
    public class AutoMapConfigure
    {
        public void AddMap<TEntity>(IMappingStrategy mappingStrategy) where TEntity : class
        {
            if (AutoMapManager.EntityMapStrategies.TryAdd(typeof(TEntity), mappingStrategy))
            {
                AutoMapManager.AddTypeMap<TEntity>();
            }
            else
            {
                throw new InvalidOperationException($"Adding entity map for type '{typeof(TEntity)}' failed. The type already exists. Current entity maps: " + string.Join(", ", AutoMapManager.EntityMapStrategies.Select(e => e.Key.ToString())));
            }
        }

    }
}
