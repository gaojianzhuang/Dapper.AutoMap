namespace Dapper.AutoMap;

public class ToLowerMappingStrategy : IMappingStrategy
{
    public string To(string from)
    {
        return string.IsNullOrEmpty(from)
                   ? from
                   : from.ToLowerInvariant();
    }
}
