/*
Profit , Loss of a business, Business Transaction, Account:, Capital:, Gain:, Purchases:, Purchase return, Sales:, 
Sales return, Income:, Expense:, Discount in business enterprise Dot Net Core MVC Project in ChatGPT
*/

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BusinessEnterprise.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<BusinessService>();  // Register the BusinessService for dependency injection

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ProfitLoss}/{action=Index}/{id?}");

app.Run();


/*
https://localhost:7095/ProfitLoss/Index
https://localhost:7095/Transaction/Index
*/