using System;

namespace IdentityApp.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message=null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessage(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessage(int statusCode)
        {
            return StatusCode switch
            {
                400 => "a bad request. You have made.",
                401 => "Authorized! You are not.",
                404 =>"Resource Not Found",
                500 => "Internal Server Error Occurred.",
                _ => null
            };
        }

    }
}
