using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.AutoMap
{
    public static class AutoMapManager
    {
        private static readonly AutoMapConfigure _configuration = new AutoMapConfigure();

        /// <summary>
        /// Gets the dictionary containing the entity mapping per entity type.
        /// </summary>
        public static readonly ConcurrentDictionary<Type, IMappingStrategy> EntityMapStrategies = new ConcurrentDictionary<Type, IMappingStrategy>();

        /// <summary>
        /// Gets the dictionary containing the strategies per entity type.
        /// </summary>
        public static readonly ConcurrentDictionary<Type, IList<IMappingStrategy>> TypeMapStrategies = new ConcurrentDictionary<Type, IList<IMappingStrategy>>();

        
        public static readonly ConcurrentDictionary<Type, Dictionary<string, string>> EntityPropertyMaps = new ConcurrentDictionary<Type, Dictionary<string, string>>();

        public static void Initialize(Action<AutoMapConfigure> configure)
        {
            configure(_configuration);
        }

        /// <summary>
        /// Registers a Dapper type map using fluent mapping for the specified <typeparamref name="TEntity"/>.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        internal static void AddTypeMap<TEntity>()
        {
            //SqlMapper.SetTypeMap(typeof(TEntity), new AutoMapManager<TEntity>());
        }
    }
}
