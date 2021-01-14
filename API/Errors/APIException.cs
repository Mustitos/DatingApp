namespace API.Errors
{
    public class APIException
    {
        public APIException(int statusCode, string message = null, string details = null)
        {
            this.statusCode = statusCode;
            Message = message;
            Details = details;
        }

        public int statusCode { get; set; }

        public string Message { get; set; }

        public string Details { get; set; }
    }
}