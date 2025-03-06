namespace KindPaws.UI.Types;

public class Result
{
    private object? _some;
    private object? _err;

    private Result(object? some, object? err)
    {
        _some = some;
        _err = err;
    }
    
    public static Result Ok(object value)
    {
        return new Result(value, null);
    }

    public static Result Err(object err)
    {
        return new Result(null, err);
    }

    public bool IsOk() => _some is not null;
    public bool IsErr() => _err is not null;

    public object Unwrap()
    {
        if (_some is null) throw new Exception("bvabvads");
        return _some;
    }

    public object Expect(string message)
    {
        if (_some is null) throw new Exception(message);
        return _some;
    }
}