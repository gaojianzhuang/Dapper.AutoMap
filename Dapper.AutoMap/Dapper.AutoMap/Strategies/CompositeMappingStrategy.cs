using System.Collections.Generic;
using System.Linq;

namespace Dapper.AutoMap;

public class CompositeMappingStrategy : IMappingStrategy
{
    public ICollection<IMappingStrategy> Strategies { get; set; }

    public string To(string from)
    {
        return Strategies.Aggregate(from, (current, strategy) => strategy.To(current));
    }
}
