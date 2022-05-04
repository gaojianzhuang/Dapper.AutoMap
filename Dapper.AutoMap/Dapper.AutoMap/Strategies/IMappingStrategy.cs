using System;

namespace Dapper.AutoMap;

public interface IMappingStrategy
{
	string To(string from);
}

public enum MappingStrategyItem
{
	AddPrefixMappingStrategy = 1,
	AddSuffixMappingStrategy = 2,
	AddUnderscoresBetweenWordsMappingStrategy = 3,
	RemovePrefixMappingStrategy = 4,
	RemoveSuffixMappingStrategy = 5,
	ToLowerMappingStrategy = 6,
	ToUperMappingStrategy = 7
}
