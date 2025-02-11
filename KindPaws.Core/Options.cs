namespace KindPaws.Core;

public static class Options
{
    public static readonly string CONNECTION_INFO = Environment.GetEnvironmentVariable("DATABASE_ACCESS")!;
}