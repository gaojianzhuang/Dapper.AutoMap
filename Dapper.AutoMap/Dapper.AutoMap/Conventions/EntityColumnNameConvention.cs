using Dapper.FluentMap.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dapper.AutoMap;

public class EntityColumnNameConvention : Convention
{
    private static IMappingStrategy MappingStrategy = MappingStrategyManager.EntityPropertyNameMappingStrategy.Value;

    public EntityColumnNameConvention()
    {
        Properties().Configure(c => c.Transform(s => StrategyTransform(s)));
    }

    private string StrategyTransform(string propertyInfo)
    {
        return MappingStrategy.To(propertyInfo);
    }
}
