

using Grpc.Net.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

using var userChannel = GrpcChannel.ForAddress("http://172.24.208.1:30000");
using var authChannel = GrpcChannel.ForAddress("http://172.24.208.1:30001");
using var productChannel = GrpcChannel.ForAddress("http://172.24.208.1:30002");
using var stockChannel = GrpcChannel.ForAddress("http://172.24.208.1:30003");
using var orderChannel = GrpcChannel.ForAddress("http://172.24.208.1:30004");
using var shippingChannel = GrpcChannel.ForAddress("http://172.24.208.1:30005");
using var invoiceChannel = GrpcChannel.ForAddress("http://172.24.208.1:30006");

var userClient = new UserService.User.UserClient(userChannel);
var authClient = new AuthService.Auth.AuthClient(authChannel);
var productClient = new ProductService.Product.ProductClient(productChannel);
var stockClient = new StockService.Stock.StockClient(stockChannel);
var orderClient = new OrderService.Order.OrderClient(orderChannel);
var shippingClient = new ShippingService.Shipping.ShippingClient(shippingChannel);
var invoiceClinet = new InvoiceService.Invoice.InvoiceClient(invoiceChannel);

builder.Services.Add(ServiceDescriptor.Singleton(typeof(UserService.User.UserClient), userClient));
builder.Services.Add(ServiceDescriptor.Singleton(typeof(AuthService.Auth.AuthClient), authClient));
builder.Services.Add(ServiceDescriptor.Singleton(typeof(ProductService.Product.ProductClient), productClient));
builder.Services.Add(ServiceDescriptor.Singleton(typeof(StockService.Stock.StockClient), stockClient));
builder.Services.Add(ServiceDescriptor.Singleton(typeof(OrderService.Order.OrderClient), orderClient));
builder.Services.Add(ServiceDescriptor.Singleton(typeof(ShippingService.Shipping.ShippingClient), shippingClient));
builder.Services.Add(ServiceDescriptor.Singleton(typeof(InvoiceService.Invoice.InvoiceClient), invoiceClinet));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
