using System.Net;
using System.Text;
using System.Xml;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Middlewares;

public class OutputFormatMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext context)
    {
        var query = context.Request.Query;
        if (
            !query.ContainsKey("output")
            || !query["output"].ToString().Equals("xml", StringComparison.OrdinalIgnoreCase)
        )
        {
            await next(context);
            return;
        }

        var originalResponseBody = context.Response.Body;

        try
        {
            await using var responseBody = new MemoryStream();
            context.Response.Body = responseBody;

            await next(context);

            responseBody.Seek(0, SeekOrigin.Begin);
            var jsonResponse = await new StreamReader(responseBody).ReadToEndAsync();

            var response = jsonResponse;
            if (
                context.Response.StatusCode is (int)HttpStatusCode.OK or (int)HttpStatusCode.Created
            )
            {
                response = ConvertJsonToXml(response);

                if (response != jsonResponse)
                {
                    context.Response.ContentType = "application/xml";
                }
            }

            var responseBytes = Encoding.UTF8.GetBytes(response);
            await originalResponseBody.WriteAsync(responseBytes.AsMemory(0, responseBytes.Length));
        }
        finally
        {
            context.Response.Body = originalResponseBody;
        }
    }

    private static string ConvertJsonToXml(string jsonResponse)
    {
        XmlDocument? doc = JsonConvert.DeserializeXmlNode(
            "{\"item\":" + jsonResponse + "}",
            "response"
        );

        return doc?.OuterXml ?? jsonResponse;
    }
}
