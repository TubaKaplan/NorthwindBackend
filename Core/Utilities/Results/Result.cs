using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)
        {
            Message = message;
            // Success = success; instead of writing this line again we add :this(success) 
            // when you send 2 parameter it runs this constructor and below with (this:(success)) code this mean run const with one parameter
        }
        public Result(bool success)
        {
            Success = success;
            // if we send one parameter it runs just this const
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
