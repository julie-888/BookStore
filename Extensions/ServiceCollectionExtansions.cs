using BookStore.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Extensions
{
    public static class ServiceCollectionExtansions
    {
        public static IServiceCollection AddBookStorage(this IServiceCollection services)
        {
            return services.AddSingleton<IBookStorage, BookStorage>();
        }
    }
}
