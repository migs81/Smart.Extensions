namespace Smart.Extensions;

public static class ExceptionExtensions
{
    /// <summary>
    /// Determines whether the specified exception has an inner exception.
    /// </summary>
    /// <param name="exception">The exception to check.</param>
    /// <returns><see langword="true"/> if the exception has an inner exception; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="exception"/> is <see langword="null"/>.</exception>
    public static bool HasInnerException(this Exception exception)
    {
        if (exception is null)
            throw new ArgumentNullException(nameof(exception));
                
        return exception.InnerException is not null;
    }
    
    /// <summary>
    /// Retrieves the message of the innermost exception.
    /// </summary>
    /// <param name="exception">The exception to retrieve the base message from.</param>
    /// <returns>The message of the innermost exception.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="exception"/> is <see langword="null"/>.</exception>
    public static string GetBaseMessage(this Exception exception)
    {
        if (exception is null)
            throw new ArgumentNullException(nameof(exception));
        
        return exception.GetBaseException().Message;
    }
    
    /// <summary>
    /// Retrieves the messages of the specified exception and all its inner exceptions.
    /// </summary>
    /// <param name="exception">The exception to retrieve the messages from.</param>
    /// <returns>A string containing all exception messages, separated by the platform-specific newline sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="exception"/> is <see langword="null"/>.</exception>
    public static string GetFullMessage(this Exception exception)
    {
        if (exception is null)
            throw new ArgumentNullException(nameof(exception));
        
        var messages = new List<string>();
        for (var ex = exception; ex is not null; ex = ex.InnerException)
            messages.Add(ex.Message);

        return string.Join(Environment.NewLine, messages);
    }

    /// <summary>
    /// Retrieves the messages of the specified exception and all its inner exceptions.
    /// </summary>
    /// <param name="exception">The exception to retrieve the messages from.</param>
    /// <returns>A list containing all exception messages.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="exception"/> is <see langword="null"/>.</exception>
    public static List<string> GetMessages(this Exception exception)
    {
        if (exception is null)
            throw new ArgumentNullException(nameof(exception));

        var messages = new List<string>();
        for (var ex = exception; ex is not null; ex = ex.InnerException)
            messages.Add(ex.Message);

        return messages;
    }
    
    /// <summary>
    /// Determines whether the specified exception or any of its inner exceptions is of the specified type.
    /// </summary>
    /// <typeparam name="TException">The exception type to search for.</typeparam>
    /// <param name="exception">The exception to check.</param>
    /// <returns><see langword="true"/> if the exception or any of its inner exceptions is of type <typeparamref name="TException"/>; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="exception"/> is <see langword="null"/>.</exception>
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