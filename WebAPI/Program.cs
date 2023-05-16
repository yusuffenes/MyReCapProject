using Business.Abstract;
using Business.Concrete;
using DateAccess.Abstract;
using DateAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IProductService, ProductManager>();
builder.Services.AddSingleton<IProductDal, EfProductDal>();
builder.Services.AddSingleton<ICustomerServices,CustomerManager>();
builder.Services.AddSingleton<ICustomerDal,EfCustomersDal>();
builder.Services.AddSingleton<IOrderService,OrderManager>();
builder.Services.AddSingleton<IOrderDal, EfOrderDal>();

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
