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
        private static readonly IColumnNameResolver DefaultResolver = new DefaultColumnNameResolver();
        private static readonly IMappingStrategy MappingStrategy = MappingStrategyManager.EntityPropertyNameMappingStrategy.Value;

        public string ResolveColumnName(PropertyInfo propertyInfo)
        {
            var columnName = MappingStrategy.To(propertyInfo.Name);
            return columnName ?? DefaultResolver.ResolveColumnName(propertyInfo);
        }
    }
}
