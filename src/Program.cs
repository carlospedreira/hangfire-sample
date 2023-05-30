using Hangfire;
using Hangfire.MemoryStorage;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHangfire(options => options.UseMemoryStorage());
builder.Services.AddHangfireServer();

var app = builder.Build();

app.UseHangfireDashboard();

BackgroundJob.Enqueue(() => Console.WriteLine("Hello world from Hangfire!"));

RecurringJob.AddOrUpdate("TEST-001", () => Console.WriteLine("Hello world recurring from Hangfire!"), Cron.Minutely);

app.Run();