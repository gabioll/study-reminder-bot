using RestSharp;

namespace StudyReminderBot.Services
{
    public class WhatsAppService
    {
        private readonly RestClient _client; // cliente HTTP para fazer requisições
        private readonly string _apiKey;     // chave de acesso da Evolution API

        public WhatsAppService()
        {
            // lê as configurações do arquivo .env
            var baseUrl = Environment.GetEnvironmentVariable("EVOLUTION_API_URL");
            _apiKey = Environment.GetEnvironmentVariable("EVOLUTION_API_KEY");

            // cria o cliente HTTP apontando para a Evolution API
            _client = new RestClient(baseUrl);
        }

        // envia uma mensagem para um número ou grupo
        public async Task EnviarMensagemAsync(string numero, string mensagem)
        {
            var instanceName = Environment.GetEnvironmentVariable("EVOLUTION_INSTANCE_NAME");

            // monta a requisição
            var request = new RestRequest($"/message/sendText/{instanceName}", Method.Post);
            request.AddHeader("apikey", _apiKey);
            request.AddHeader("Content-Type", "application/json");

            // corpo da mensagem
            request.AddJsonBody(new
            {
                number = numero,        // destinatário
                text = mensagem         // conteúdo da mensagem
            });

            // envia a requisição
            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful)
                Console.WriteLine($"✅ Mensagem enviada para {numero}");
            else
                Console.WriteLine($"❌ Erro ao enviar para {numero}: {response.ErrorMessage}");
        }
    }
}