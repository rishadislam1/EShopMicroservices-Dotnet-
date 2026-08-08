var builder = WebApplication.CreateBuilder(args);

// add services 


var app = builder.Build();

// confiugure the http request pipeline

app.Run();
