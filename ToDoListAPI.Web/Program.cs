using ToDoListAPI.Web.StartupExtensions;


var builder = WebApplication.CreateBuilder(args);

//Inject and configure necessary services for the application.
builder.Services.ConfigureServices(builder.Configuration);

var app = builder.Build();



app.Run();
