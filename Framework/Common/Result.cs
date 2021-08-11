using System.Threading.Tasks;

namespace Framework.Common
{
    public class Result : IResult
    {
        public bool Failed => !Succeeded;

        public string Message { get; set; }

        public bool Succeeded { get; set; }

        public static IResult Fail() => new Result
        {
            Succeeded = false
        };

        public static IResult Fail(string message) => new Result
        {
            Succeeded = false,
            Message = message
        };

        public static Task<IResult> FailAsync() => Task.FromResult(Fail());

        public static Task<IResult> FailAsync(string message) => Task.FromResult(Fail(message));

        public static IResult Success() => new Result
        {
            Succeeded = true
        };

        public static IResult Success(string message) => new Result
        {
            Succeeded = true,
            Message = message
        };

        public static Task<IResult> SuccessAsync() => Task.FromResult(Success());

        public static Task<IResult> SuccessAsync(string message) => Task.FromResult(Success(message));
    }
    public class Result<T> : Result, IResult<T>, IResult
    {
        public T Data { get; set; }

        public static Result<T> Fail()
        {
            Result<T> result = new Result<T>();
            result.Succeeded = false;
            return result;
        }

        public static Result<T> Fail(string message)
        {
            Result<T> result = new Result<T>();
            result.Succeeded = false;
            result.Message = message;
            return result;
        }

        public static Task<Result<T>> FailAsync() => Task.FromResult<Result<T>>(Result<T>.Fail());

        public static Task<Result<T>> FailAsync(string message) => Task.FromResult<Result<T>>(Result<T>.Fail(message));

        public static Result<T> Success()
        {
            Result<T> result = new Result<T>();
            result.Succeeded = true;
            return result;
        }

        public static Result<T> Success(string message)
        {
            Result<T> result = new Result<T>();
            result.Succeeded = true;
            result.Message = message;
            return result;
        }

        public static Result<T> Success(T data)
        {
            Result<T> result = new Result<T>();
            result.Succeeded = true;
            result.Data = data;
            return result;
        }

        public static Result<T> Success(T data, string message)
        {
            Result<T> result = new Result<T>();
            result.Succeeded = true;
            result.Data = data;
            result.Message = message;
            return result;
        }

        public static Task<Result<T>> SuccessAsync() => Task.FromResult<Result<T>>(Result<T>.Success());

        public static Task<Result<T>> SuccessAsync(string message) => Task.FromResult<Result<T>>(Result<T>.Success(message));

        public static Task<Result<T>> SuccessAsync(T data) => Task.FromResult<Result<T>>(Result<T>.Success(data));

        public static Task<Result<T>> SuccessAsync(T data, string message) => Task.FromResult<Result<T>>(Result<T>.Success(data, message));
    }
}