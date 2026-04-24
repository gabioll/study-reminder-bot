using StudyReminderBot.Services;

namespace StudyReminderBot
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;           // para registrar logs
        private readonly NotificationService _notificationService; // serviço de notificações

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            _notificationService = new NotificationService();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // fica rodando enquanto o bot estiver ativo
            while (!stoppingToken.IsCancellationRequested)
            {
                var agora = DateTime.Now;

                // envia os lembretes todo dia às 8h da manhã
                if (agora.Hour == 8 && agora.Minute == 0)
                {
                    _logger.LogInformation("📚 Enviando lembretes da semana...");
                    await _notificationService.EnviarLembretesSemanaAsync();
                    _logger.LogInformation("✅ Lembretes enviados com sucesso!");
                }

                // aguarda 1 minuto antes de verificar novamente
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}