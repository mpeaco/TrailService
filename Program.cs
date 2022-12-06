using Microsoft.EntityFrameworkCore;
using TrailService.Data;

var builder = WebApplication.CreateBuilder(args);


IConfiguration configuration = builder.Configuration;
var server = configuration["DbServer"] ?? "localhost";
var port = configuration["DbPort"] ?? "1433";
var user = configuration["DbUser"] = "SA";
var pwd = configuration["DbPwd"] = "C0mp2001!";
var database = configuration["DB"] = "Mark_peacockDB";

// Add services to the container.
builder.Services.AddDbContext<TrailDbContext>(opt =>
{
    //opt.UseInMemoryDatabase("InMem");

    // Using the database string for local mssql 
    opt.UseSqlServer(($"Server={server}, {port};Initial Catalog={database};User ID={user};Password={pwd}; TrustServerCertificate=true"));

    opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);


});

// Add interface and class
builder.Services.AddScoped<ITrailRepo, TrailRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//PrepSampleDb.PrepPopulation(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
