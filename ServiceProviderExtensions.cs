namespace HelloApp
{
    public static class ServiceProviderExtensions
    {
        public static void addTimeService(this IServiceCollection services)
        {
            services.AddTransient<TimeService>();
        }
    }
}
