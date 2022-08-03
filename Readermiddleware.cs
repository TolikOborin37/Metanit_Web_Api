namespace HelloApp
{
    public class Readermiddleware
    {
        IReader reader;
        public Readermiddleware(RequestDelegate _, IReader reader) => this.reader = reader;

        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync($"Current value: {reader.readValue()}");
        }
    }
}
