using API.Startup;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureEntityFrameworkCore(builder.Configuration);
builder.Services.AddAuthentication();
builder.Services.ConfigureIdentityCore();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();

app.Run();