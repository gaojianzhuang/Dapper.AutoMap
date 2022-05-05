using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dapper.AutoMap;

public class RemoveSuffixMappingStrategy : IMappingStrategy
{
    private string suffixToRemove;

    public RemoveSuffixMappingStrategy(string suffixToRemove)
    {
        this.suffixToRemove = suffixToRemove;
    }

    public string To(string from)
    {
        if (!string.IsNullOrWhiteSpace(from) 
            && from.EndsWith(suffixToRemove, StringComparison.InvariantCultureIgnoreCase))
        {
            return from.Substring(0, from.LastIndexOf(suffixToRemove, StringComparison.InvariantCultureIgnoreCase));
        }
        else
        {
            return from;
        }
    }
}
