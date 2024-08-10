using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System.Text;

namespace ContentNegotiation.Formatters
{
    public class CustomOutputFormatter : TextOutputFormatter
    {
        public CustomOutputFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/custom"));

            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
            Console.WriteLine("CustomOutputFormatter object id = " + Guid.NewGuid());
        }

        protected override bool CanWriteType(Type? type)
            => typeof(WeatherForecast).IsAssignableFrom(type)
                || typeof(IEnumerable<WeatherForecast>).IsAssignableFrom(type);

        public override async Task WriteResponseBodyAsync(
            OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            var httpContext = context.HttpContext;
            var serviceProvider = httpContext.RequestServices;

            var logger = serviceProvider.GetRequiredService<ILogger<CustomOutputFormatter>>();
            var buffer = new StringBuilder();

            if (context.Object is IEnumerable<WeatherForecast> contacts)
            {
                foreach (var contact in contacts)
                {
                    //FormatVcard(buffer, contact, logger);
                    buffer.Append(contact.Date + "=" + contact.TemperatureC + "=" + contact.Summary);
                }
            }
            else
            {
                var contact = (WeatherForecast)context.Object!;
                buffer.Append(contact.Date + "=" + contact.TemperatureC + "=" + contact.Summary);
            }

            await httpContext.Response.WriteAsync(buffer.ToString(), selectedEncoding);
        }
    }
}
