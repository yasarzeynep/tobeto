using Business.Abstract;
using Business.BrandBusinessRules;
using Business.Concrete;
using Business.DependencyResolves;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

/*// Add services to the container.
 * Singleton:Tek bir nesne olusturur ve herhese onu verir.
 * Ek odev diger yöntemleri arastýrýnýz;Singleton,Scoped, Transient
 * builder.Services.AddSingleton<IBrandService, BrandManager>();
/*builder.Services.AddSingleton<IBrandDal, InMemoryBrandDal>();
/*builder.Services.AddSingleton<BrandBusinessRules>();
 *
/*builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());// AutoMapper.Extensions.Microsoft.DependencyInjection NuGet Paketi
 *Reflection yöntemiyle Profile class'ýný katýlým alan tüm classlarý bulur ve Automapper'a ekler.
 */

builder.Services.AddControllers();
builder.Services.AddBusinessService();  
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
