using Dommel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.AutoMap.Resolvers
{
    public class AutoMapTableNameResolver : ITableNameResolver
    {
        private static readonly ITableNameResolver DefaultResolver = new DefaultTableNameResolver();
        private static readonly IMappingStrategy MappingStrategy = MappingStrategyManager.EntityTableNameMappingStrategy.Value;

        private static string EntityPrefix { get; set; }

        public AutoMapTableNameResolver()
        { 
        }

        public AutoMapTableNameResolver(string entityPrefix)
        {
            EntityPrefix = entityPrefix;
        }

        public string ResolveTableName(Type type)
        {
            MappingStrategyManager.EntityPrefix = EntityPrefix ?? "Dxp";
            var tableName = MappingStrategy.To(type.Name);
            return tableName ?? DefaultResolver.ResolveTableName(type);
        }
    }
}
