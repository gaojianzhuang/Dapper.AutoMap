namespace Dapper.AutoMap;

public class ToUperMappingStrategy : IMappingStrategy
{
    public string To(string from)
    {
        return string.IsNullOrEmpty(from)
                   ? from
                   : from.ToUpperInvariant();
    }
}
