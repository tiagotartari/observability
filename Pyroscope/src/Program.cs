var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Pyroscope.Profiler.Instance.SetAllocationTrackingEnabled(true);
Pyroscope.Profiler.Instance.SetExceptionTrackingEnabled(true);
Pyroscope.Profiler.Instance.SetContentionTrackingEnabled(true);
Pyroscope.Profiler.Instance.SetCPUTrackingEnabled(true);

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.MapControllers();
app.Run();