using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace WebApiBicingGP.Domain
{
    public class Result<T> : IActionResult
    {
        public readonly T ResultData;
        public Result(T data)
        {
            ResultData = data;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var response = context.HttpContext.Response;
            response.StatusCode = (int)HttpStatusCode.OK;
            response.ContentType = "application/json";
            var jsonData = JsonConvert.SerializeObject(ResultData);
            await response.WriteAsync(jsonData);
        }
    }

}