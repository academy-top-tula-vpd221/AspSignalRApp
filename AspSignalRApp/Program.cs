using AspSignalRApp;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

//builder.Services.AddSignalR().AddHubOptions<ChatHub>(hubOption =>
//{
//    //hubOption.EnableDetailedErrors = false;
//    hubOption.KeepAliveInterval = TimeSpan.FromMinutes(2);
//});

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapHub<ChatHub>("/chat");


app.Run();
