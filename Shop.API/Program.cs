using Shop.Core.Repositories;
using Shop.Core.Services;
using Shop.Core;
using Shop.Data;
using Shop.Data.Repositories;
using Shop.Service;
using System.Text.Json.Serialization;
using Shop.API.Middlewares;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(option => { option.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; option.JsonSerializerOptions.WriteIndented = true; });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IBuyingService, BuyingService>();
builder.Services.AddScoped<IBuyingRepository, BuyingRepository>();
builder.Services.AddScoped<IOrdersService, OrdersService>();
builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();
builder.Services.AddDbContext<DataContext>();
//builder.Services.AddSingleton<DataContext>();
//builder.Services.AddCors(opt => opt.AddPolicy("MyPolicy", policy =>{ policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();}));
//builder.Services.AddAutoMapper(typeof(MappingProfile));
//builder.Services.AddAutoMapper(cfg => cfg.AddProfile<MappingProfile>());
builder.Services.AddAutoMapper(typeof(MappingProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//app.UseCors("MyPolicy");
app.UseAuthorization();
app.UseMiddleware<ShbbatMiddleWares>(); 

app.MapControllers();

app.Run();
