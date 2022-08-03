namespace HelloApp
{
    public class GeneratorMiddleware
    {
        RequestDelegate next;
        IGenerator generator;

        public GeneratorMiddleware(RequestDelegate next, IGenerator generator)
        {
            this.next = next;
            this.generator = generator;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if(context.Request.Path=="/generate")
            {
                await context.Response.WriteAsync($"New value: {generator.GenerateValue()}");
            }
            else
            {
                await next.Invoke(context);
            }
        }
    }
}
