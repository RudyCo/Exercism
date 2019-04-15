using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception("HandleErrorByThrowingException");
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        return int.TryParse(input, out int res) ? res : default(int?);
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        return int.TryParse(input, out result);
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        if (disposableObject != null) disposableObject.Dispose();
        throw new Exception("DisposableResourcesAreDisposedWhenExceptionIsThrown");
    }
}