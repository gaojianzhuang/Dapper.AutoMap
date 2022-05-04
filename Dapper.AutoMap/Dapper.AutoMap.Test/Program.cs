// See https://aka.ms/new-console-template for more information
using MySql.Data.MySqlClient;
using System.Data.Common;
using Dapper;
using Dommel;
using Dapper.FluentMap.Mapping;
using Dapper.FluentMap;
using Dapper.AutoMap;
using System.Reflection;
using Dapper.AutoMap.Test.Models;
using Dapper.FluentMap.TypeMaps;
using Dapper.AutoMap.Resolvers;

Console.WriteLine("Hello, World!");

FluentMapper.Initialize(config =>
{
    //config.AddMap(new CategoryMap());
    //config.AddConvention<DefaultEntityConvention>()
    //      .ForEntity<Category>();

    config.AddConvention<DefaultEntityConvention>()
          .ForEntitiesInAssembly(typeof(Category).Assembly, "Dapper.AutoMap.Test.Models");
});

var connectionString = "";
using var connection = new MySqlConnection(connectionString);
var results = connection.Query<Category>("SELECT * FROM dxp_category");

Console.WriteLine(results.Count());

var tableResolver = new AutoMapTableNameResolver("Dxp");
var columnResolver = new AutoMapColumnNameResolver();
DommelMapper.SetColumnNameResolver(columnResolver);
DommelMapper.SetTableNameResolver(tableResolver);
var category = await connection.GetAsync<Category>(1);
var selectCategory = await connection.SelectAsync<Category>(c => c.CategoryId == 1);
Console.WriteLine(category?.CategoryId);