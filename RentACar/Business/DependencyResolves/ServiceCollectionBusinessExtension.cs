using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolves;

public static class ServiceCollectionBusinessExtension
{
    // Extension method
    // Metodun ve barındığı class'ın static olması gerekiyor
    // İlk parametere genişleteceğimiz tip olmalı ve başında this keyword'ü olmalı.
    public static IServiceCollection AddBusinessService(this IServiceCollection services)
    {
        services    //Fluent Yapı
        .AddSingleton<IBrandService, BrandManager>()
        .AddSingleton<IBrandDal, InMemoryBrandDal>()
        .AddSingleton<BrandBusinessRules>(); //Fluent Yapı

        /*Singleton:Tek bir nesne olusturur ve herkese o nu verir
         Ek odev diger yöntemleri arastırınız
         */
        services.AddAutoMapper(Assembly.GetExecutingAssembly()); // AutoMapper.Extensions.Microsoft.DependencyInjection NuGet Paketi
                                                                 // Reflection yöntemiyle Profile class'ını kalıtım alan tüm class'ları bulur ve AutoMapper'a ekler.

        return services;  // AutoMapper.Extensions.Microsoft.DependencyInjection NuGet Paketi

    }
}
