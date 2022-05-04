using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dapper.AutoMap;

public class RemovePrefixMappingStrategy : IMappingStrategy
{
    private string prefixToRemove;

    public RemovePrefixMappingStrategy(string prefixToRemove)
    {
        this.prefixToRemove = prefixToRemove;
    }

    public string To(string from)
    {
        if (!string.IsNullOrWhiteSpace(from) 
            && from.EndsWith(prefixToRemove, StringComparison.InvariantCultureIgnoreCase))
        {
            return from.Substring(0, from.IndexOf(prefixToRemove, StringComparison.InvariantCultureIgnoreCase));
        }
        else
        {
            return from;
        }
    }
}
