namespace ECourseMicroservice.Catolog.Api.Options
{
    public static class OptionExt
    {
        public static IServiceCollection AddOptiosExt(this IServiceCollection services) 
        {
            services.AddOptions<MongoOption>()
                    .BindConfiguration(nameof(MongoOption))
                    .ValidateDataAnnotations()
                    .ValidateOnStart();

            return services;
        }
    }
}
