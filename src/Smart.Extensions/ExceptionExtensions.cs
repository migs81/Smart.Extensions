namespace Smart.Extensions;

public static class ExceptionExtensions
{
    public static bool HasInnerException(this Exception exception)
    {
        if (exception is null)
            throw new ArgumentNullException(nameof(exception));
                
        return exception.InnerException is not null;
    }
    
    public static string GetBaseMessage(this Exception exception)
    {
        if (exception is null)
            throw new ArgumentNullException(nameof(exception));
        
        return exception.GetBaseException().Message;
    }
    
    public static string GetFullMessage(this Exception exception)
    {
        if (exception is null)
            throw new ArgumentNullException(nameof(exception));
        
        var messages = new List<string>();
        for (var ex = exception; ex is not null; ex = ex.InnerException)
            messages.Add(ex.Message);

        return string.Join(Environment.NewLine, messages);
    }

    public static List<string> GetMessages(this Exception exception)
    {
        if (exception is null)
            throw new ArgumentNullException(nameof(exception));

        var messages = new List<string>();
        for (var ex = exception; ex is not null; ex = ex.InnerException)
            messages.Add(ex.Message);

        return messages;
    }
    
    public static bool Contains<TException>(this Exception exception) where TException : Exception
    {
        if (exception is null)
            throw new ArgumentNullException(nameof(exception));

        for (var ex = exception; ex is not null; ex = ex.InnerException)
            if (ex is TException)
                return true;

        return false;
    }
}