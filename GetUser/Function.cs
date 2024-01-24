using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using System.Net;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(
    typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer)
)]

namespace GetUser;

public class Function
{
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public APIGatewayProxyResponse FunctionHandler(
        APIGatewayProxyRequest input,
        ILambdaContext context
    )
    {
        context.Logger.LogInformation(
            $"query params {JsonConvert.SerializeObject(input.QueryStringParameters)}"
        );
        return new APIGatewayProxyResponse
        {
            StatusCode = ((int)HttpStatusCode.OK),
            Body = "Some data"
        };
    }
}
