namespace Dapper.AutoMap;

public class AddSuffixMappingStrategy : IMappingStrategy
{
    private readonly string suffix;
    public AddSuffixMappingStrategy(string suffix)
    {
        this.suffix = suffix;
    }

    public string To(string from)
    {
        return from == null ? suffix : from + suffix;
    }
}
