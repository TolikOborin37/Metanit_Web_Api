//using Microsoft.Extensions.Options;
//namespace HelloApp
//{
//    public class PersonMiddleware
//    {
//        private readonly RequestDelegate _next;
//        public Person person { get; }
//        public PersonMiddleware(RequestDelegate next,IOptions<Person> options)
//        {
//            _next = next;
//            person =options.Value;
//        }
//        public async Task InvokeAsync(HttpContext context)
//        {
//            System.Text.StringBuilder stringBuilder = new();
//            stringBuilder.Append($"<p>Name: {person.Name}</p>");
//            stringBuilder.Append($"<p>Age:{person.Age}</p>");
//            stringBuilder.Append($"<p>Company: {person.Company?.Title}</p>");
//            stringBuilder.Append("<h3>Languages</h3><ul>");
//            foreach (string lang in person.Languages)
//            {
//                stringBuilder.Append($"<li>{lang}</li>");
//            }
//            stringBuilder.Append("</ul");

//            await context.Response.WriteAsync(stringBuilder.ToString());
//        }
//    }
//}
