using Microsoft.EntityFrameworkCore;
using TrailService.Data;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;

// database config for localhost sql server

var server = configuration["DbServer"] ?? "localhost";
var port = configuration["DbPort"] ?? "1433";
var user = configuration["DbUser"] = "SA";
var pwd = configuration["DbPwd"] = "C0mp2001!";
var database = configuration["DB"] = "Mark_peacockDB";


/*
// Config for remote server
var server = configuration["DbServer"] ?? "socem1.uopnet.plymouth.ac.uk";
var user = configuration["DbUser"] = "MPeacock";
var pwd = configuration["DbPwd"] = "IcnR568*";
var database = configuration["DB"] = "COMP2001_MPeacock";
*/

// Add services to the container.
builder.Services.AddDbContext<TrailDbContext>(opt =>
{
    // In memory database
    //opt.UseInMemoryDatabase("InMem");

    // Using the database string for local mssql 
    opt.UseSqlServer(($"Server={server}, {port};Initial Catalog={database};User ID={user};Password={pwd}; TrustServerCertificate=true"));

    //opt.UseSqlServer(($"Server={server};Initial Catalog={database};User ID={user};Password={pwd}; TrustServerCertificate=true"));

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
