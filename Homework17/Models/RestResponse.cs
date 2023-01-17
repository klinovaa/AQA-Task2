using Newtonsoft.Json;

namespace Homework17.Models
{
    public class RestResponse : HttpResponseMessage
    {
        public string ResponseData { get; }

        public RestResponse(HttpResponseMessage responseMessage)
        {
            ResponseData = responseMessage.Content.ReadAsStringAsync().Result;
            StatusCode = responseMessage.StatusCode;
        }

        public override string ToString()
        {
            return $"StatusCode: {StatusCode}\nResponseData: {ResponseData}";
        }
    }

    public class RestResponse<T> : RestResponse where T : class
    {
        public T responseModel { get; }

        public RestResponse(HttpResponseMessage responseMessage) : base(responseMessage)
        {
            responseModel = JsonConvert.DeserializeObject<T>(ResponseData);
        }
    }
}
