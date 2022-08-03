namespace HelloApp
{
    public class HelloMiddleware
    {
        readonly IEnumerable<IHelloService> helloServices;

        public HelloMiddleware(RequestDelegate _,IEnumerable<IHelloService> helloServices)
        {
            this.helloServices = helloServices;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.ContentType = "text/html; charset=utf-8";
            string responceText = "";
            foreach(var service in helloServices)
            {
                responceText += $"<h3>{service.Message}</h3>";
            }
            await context.Response.WriteAsync(responceText);
        }
    }
}
