using AutoMapper;
using ExamPortal.Repositories;
using ExamPortal.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace ExamPortal.Utilities
{
    //seperates the code from startup.cs
    public static class ExtensionContainer
    {
        public static IServiceCollection configureDI(this IServiceCollection services)
        {
            services.AddScoped<ITeacherService, TeacherServiceImpl>();
            services.AddScoped<IStudentService, StudentServiceImpl>();
            services.AddScoped<IMCQPaperRepo, MCQPaperRepoImpl>();
            services.AddScoped<IMCQAnswerSheetRepo, MCQAnswerSheetRepoImpl>();
            services.AddScoped<IDescriptiveAnswerSheetRepo, DescriptiveAnswerSheetRepoImpl>();
            services.AddScoped<IDescriptivePaperRepo, DescriptivePaperRepoImpl>();
            services.AddAutoMapper(typeof(AutoMapperConfig));
            services.AddScoped<IFirebaseUpload, FirebaseUpload>();
            services.AddScoped<IDescriptivePaperRepo, DescriptivePaperRepoImpl>();
            services.AddScoped<IEmailService, EmailService>();
            return services;
        }

        public static void configureAuth(this IServiceCollection services)
        {
            services.AddAuthentication().AddGoogle(options =>
            {
                options.ClientId = "566313563077-ejb0mq4u9bnku8itadmc8jgov17u1e1p.apps.googleusercontent.com";
                options.ClientSecret = "QKT74XsgR5NC1oLxVjswn4M8";
            });
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 10;
                options.Password.RequiredUniqueChars = 3;
                options.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<AppDbContext>();
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var _ = list[k];
                list[k] = list[n];
                list[n] = _;
            }
        }
    }
}
