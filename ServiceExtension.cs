// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract;

using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

public static class ServiceExtensions
{
    public static IServiceCollection AddContractsDependency(this IServiceCollection services)
    {
        services.AddMapper();
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }

    private static void AddMapper(this IServiceCollection services)
    {
        var mapper = new MapperConfiguration(configuration =>
        {
            configuration.AddProfile(new AuthenticationProfile());
            configuration.AddProfile(new UserProfile());
            configuration.AddProfile(new AttorneyProfile());
            configuration.AddProfile(new StudentProfile());
            configuration.AddProfile(new MasterDataProfile());
            configuration.AddProfile(new PaymentProfile());
            configuration.AddProfile(new WorkerProfile());
            configuration.AddProfile(new NoteProfile());
            configuration.AddProfile(new CourseProfile());
            configuration.AddProfile(new TutorshipProfile());
            configuration.AddProfile(new EnrollmentProfile());
            configuration.AddProfile(new TransversalProfile());
            configuration.AddProfile(new WebProfile());
        });

        services.AddSingleton(mapper.CreateMapper());
    }
}
