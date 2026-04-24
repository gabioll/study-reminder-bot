using StudyReminderBot;
using DotNetEnv;

// carrega as variáveis do arquivo .env
Env.Load();

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();