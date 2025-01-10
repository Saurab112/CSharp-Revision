using di0_.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<MyMessageInterface, MyMessage>();
var app = builder.Build();
app.UseRouting();
app.MapControllers();
if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}

app.Run();
