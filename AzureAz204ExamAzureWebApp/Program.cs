using AzureAz204ExamAzureWebApp.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<EmployeeService>();
builder.Services.AddMvc();
var app = builder.Build();

app.MapGet("/", () => "Hello Abhishek!");

app.Run();
