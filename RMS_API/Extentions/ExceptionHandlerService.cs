using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RMS.Service.Exceptions;

namespace RMS.API.Extentions
{
    public static class ExceptionHandlerService
    {
        public static void AddExceptionsHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(error =>
            {
                error.Run(async context =>
                {
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    var code = 500;
                    string message = "Inter Server Error. Please Try Again Later!";
                    if (contextFeature!=null)
                    {
                        message = contextFeature.Error.Message;
                        if (contextFeature.Error is NotFoundException)
                        {
                            code = 404;
                        }
                        else if (contextFeature.Error is AlreadyExistException)
                        {
                            code = 409;
                        }
                        else if (contextFeature.Error is FileFormatException)
                        {
                            code = 400;
                        }

                    }
                    context.Response.StatusCode = code;

                    var contextJsonStr = JsonConvert.SerializeObject(new
                    {
                        code = code,
                        message = message
                    });

                    await context.Response.WriteAsync(contextJsonStr);
                });
            });
        }
    }
}
