using Dapper.FluentMap.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dapper.AutoMap;

public class DefaultEntityConvention : Convention
{
    private static IMappingStrategy _mappingStrategy = MappingStrategyManager.EntityPropertyNameMappingStrategy.Value;

    public DefaultEntityConvention()
    {
        // Method 1: use the regex to transform the property name
        Properties().Configure(c => c.Transform(s => Regex.Replace(input: s, pattern: "([A-Z])([A-Z][a-z])|([a-z0-9])([A-Z])", replacement: "$1$3_$2$4").ToLower()));
        // Method 2: use the strategy to transform the property name
        //Properties().Configure(c => c.Transform(s => _mappingStrategy.To(s)));
    }
}
