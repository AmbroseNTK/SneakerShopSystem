

using Grpc.Net.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

using var userChannel = GrpcChannel.ForAddress("http://localhost:30000");
using var authChannel = GrpcChannel.ForAddress("http://localhost:30001");

var userClient = new UserService.User.UserClient(userChannel);
var authClient = new AuthService.Auth.AuthClient(authChannel);

builder.Services.Add(ServiceDescriptor.Singleton(typeof(UserService.User.UserClient), userClient));


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
