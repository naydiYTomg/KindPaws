using Dapper;
using KindPaws.Core;
using Npgsql;

namespace KindPaws.DAL.Utils;

public class ConnectionBuilder : IConnectionBuilderNull, IConnectionBuilderWithQuery, IConnectionBuilderWithProperties
{
    private string _query;
    private object? _properties;
    public static IConnectionBuilderNull Create() => new ConnectionBuilder();
    
    public IConnectionBuilderWithQuery WithQuery(string query)
    {
        _query = query;
        return this;
    }

    public IConnectionBuilderWithProperties WithProperties(object? properties)
    {
        _properties = properties;
        return this;
    }

    public Connection Build()
    {
        return new Connection { Query = _query, Properties = _properties };
    }
}


public interface IConnectionBuilderNull
{
    IConnectionBuilderWithQuery WithQuery(string query);
}
  
public interface IConnectionBuilderWithQuery
{
    IConnectionBuilderWithProperties WithProperties(object? properties);
    Connection Build();
}

public interface IConnectionBuilderWithProperties
{
    Connection Build();
}

public class Connection
{
    public required string Query { get; init; }
    public object? Properties { get; init; }

    public T ExecuteFirst<T>()
    {
        using var connection = new NpgsqlConnection(Options.CONNECTION_INFO);
        var result = Properties is null
            ? connection.Query<T>(Query).First()
            : connection.Query<T>(Query, Properties).First();
        return result;
    }

    public IEnumerable<T> Execute<T>()
    {
        using var connection = new NpgsqlConnection(Options.CONNECTION_INFO);
        var result = Properties is null
            ? connection.Query<T>(Query)
            : connection.Query<T>(Query, Properties);
        return result;
    }
}