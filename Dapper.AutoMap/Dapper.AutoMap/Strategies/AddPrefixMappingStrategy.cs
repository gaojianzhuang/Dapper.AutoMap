namespace Dapper.AutoMap;

public class AddPrefixMappingStrategy : IMappingStrategy
{
    private readonly string prefix;
    public AddPrefixMappingStrategy(string prefix)
    {
        this.prefix = prefix;
    }

    public string To(string from)
    {
        return prefix == null ? from : prefix + from;
    }
}
