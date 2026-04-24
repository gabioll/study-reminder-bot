using StudyReminderBot.Models;

namespace StudyReminderBot.Services
{
    public class NotificationService
    {
        private readonly GoogleSheetsService _sheetsService;   // serviço da planilha
        private readonly WhatsAppService _whatsAppService;     // serviço do WhatsApp

        public NotificationService()
        {
            _sheetsService = new GoogleSheetsService();
            _whatsAppService = new WhatsAppService();
        }

        // envia os lembretes da semana
        public async Task EnviarLembretesSemanaAsync()
        {
            // lê os dados da planilha
            var atividades = await _sheetsService.GetAtividadesAsync();
            var integrantes = await _sheetsService.GetIntegrantesAsync();
            var destinos = await _sheetsService.GetDestinosAsync();

            // filtra atividades da semana atual
            var hoje = DateTime.Today;
            var fimDaSemana = hoje.AddDays(7);
            var atividadesDaSemana = atividades
                .Where(a => a.DataLimite >= hoje && a.DataLimite <= fimDaSemana)
                .ToList();

            if (!atividadesDaSemana.Any()) return;

            // monta a mensagem do grupo
            var mensagemGrupo = MontarMensagemGrupo(atividadesDaSemana);

            // envia para os destinos ativos
            foreach (var destino in destinos.Where(d => d.Ativo == "Sim"))
            {
                await _whatsAppService.EnviarMensagemAsync(destino.Numero, mensagemGrupo);
            }

            // envia notificações individuais
            foreach (var integrante in integrantes.Where(i => i.RecebeIndividual == "Sim"))
            {
                var mensagemIndividual = MontarMensagemIndividual(integrante, atividadesDaSemana);
                await _whatsAppService.EnviarMensagemAsync(integrante.Numero, mensagemIndividual);
            }
        }

        // monta a mensagem para o grupo
        private string MontarMensagemGrupo(List<Atividade> atividades)
        {
            var mensagem = "📚 *Lembretes da Semana*\n\n";

            foreach (var atividade in atividades)
            {
                mensagem += $"📌 *{atividade.Nome}*\n";
                mensagem += $"   Microfundamento: {atividade.Microfundamento}\n";
                mensagem += $"   Pontuação: {atividade.Pontuacao}\n";
                mensagem += $"   Data Limite: {atividade.DataLimite:dd/MM/yyyy}\n";
                mensagem += $"   Tipo: {atividade.Tipo}\n";
                mensagem += $"   🔗 Link: {atividade.Link}\n\n"; // link da atividade
            }

            mensagem += "⚠️ Fique atento aos prazos!";
            return mensagem;
        }

        // monta a mensagem individual para cada integrante
        private string MontarMensagemIndividual(Integrante integrante, List<Atividade> atividades)
        {
            var mensagem = $"👤 *Seus lembretes da semana, {integrante.Nome}!*\n\n";

            foreach (var atividade in atividades)
            {
                mensagem += $"📌 *{atividade.Nome}*\n";
                mensagem += $"   Microfundamento: {atividade.Microfundamento}\n";
                mensagem += $"   Pontuação: {atividade.Pontuacao}\n";
                mensagem += $"   Data Limite: {atividade.DataLimite:dd/MM/yyyy}\n";
                mensagem += $"   🔗 Link: {atividade.Link}\n\n"; // link da atividade
            }

            mensagem += "⚠️ Fique atento aos prazos!";
            return mensagem;
        }
    }
}