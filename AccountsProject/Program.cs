using AccountsProject.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<AccountsProject.Repositories.AppDbContext>(options => options
                    .UseLazyLoadingProxies(true)
                    .UseSqlServer(builder.Configuration.GetConnectionString("SQLServer1")));

//builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddScoped<ISupplierRepositry, SupplierRepositry>();
builder.Services.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();

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
