using Dommel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.AutoMap.Resolvers
{
    public class AutoMapColumnNameResolver : IColumnNameResolver
    {
        private static readonly IColumnNameResolver _defaultResolver = new DefaultColumnNameResolver();
        private static readonly IMappingStrategy _mappingStrategy = MappingStrategyManager.EntityPropertyNameMappingStrategy.Value;

        private static string EntityPrefix { get; set; }

        public AutoMapColumnNameResolver()
        { 
        }

        public AutoMapColumnNameResolver(string entityPrefix)
        {
            EntityPrefix = entityPrefix;
        }

        public string ResolveColumnName(PropertyInfo propertyInfo)
        {
            var columnName = _mappingStrategy.To(propertyInfo.Name);
            return columnName ?? _defaultResolver.ResolveColumnName(propertyInfo);
        }
    }
}
