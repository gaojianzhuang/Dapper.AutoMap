namespace Dapper.AutoMap;

public static class MappingStrategyManager
{
    public static readonly Lazy<IMappingStrategy> AddUnderscoresBetweenWordsThenToLowerMappingStrategy =
        new Lazy<IMappingStrategy>(() => new CompositeMappingStrategy
        {
            Strategies = new IMappingStrategy[]
            {
                new AddUnderscoresBetweenWordsMappingStrategy(),
                new ToLowerMappingStrategy()
            }
        });

    public static readonly Lazy<IMappingStrategy> EntityTableNameMappingStrategy =
        new Lazy<IMappingStrategy>(() => new CompositeMappingStrategy
        {
            Strategies = new List<IMappingStrategy>(new[]
            {
                new AddPrefixMappingStrategy (EntityPrefix),
                AddUnderscoresBetweenWordsThenToLowerMappingStrategy.Value
            })
        });

    public static readonly Lazy<IMappingStrategy> EntityPropertyNameMappingStrategy =
        new Lazy<IMappingStrategy>(() => new CompositeMappingStrategy
        {
            Strategies = new List<IMappingStrategy>(new[]
            {
                AddUnderscoresBetweenWordsThenToLowerMappingStrategy.Value
            })
        });

    public static string EntityPrefix = "Dxp";
}
