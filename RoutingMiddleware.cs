namespace HelloApp
{
    public class RoutingMiddleware
    {
        readonly RequestDelegate next;
        public RoutingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            string path = context.Request.Path;
            if(path=="/index")
            {
                await context.Response.WriteAsync("Home page");

            }
            else if(path=="/about")
            {
                await context.Response.WriteAsync("About page");
            }
            else
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Not found");
            }
        }
    }
}
