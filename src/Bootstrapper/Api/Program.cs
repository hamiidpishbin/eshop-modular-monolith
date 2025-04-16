using Basket;
using Catalog;
using Ordering;

var builder = WebApplication.CreateBuilder(args);

builder.Services
	.AddBasketModule(builder.Configuration)
	.AddCatalogModule(builder.Configuration)
	.AddOrderingModule(builder.Configuration);

var app = builder.Build();

app.UseBasketModule()
	.UseCatalogModule()
	.UseOrderingModule();

app.MapGet("/", () => "Hello World!");

app.Run();