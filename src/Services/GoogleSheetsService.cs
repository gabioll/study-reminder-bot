using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using StudyReminderBot.Models;

namespace StudyReminderBot.Services
{
    public class GoogleSheetsService
    {
        private readonly SheetsService _sheetsService; // serviço do Google Sheets
        private readonly string _spreadsheetId;         // ID da planilha

        public GoogleSheetsService()
        {
            // lê o caminho das credenciais do arquivo .env
            var credentialsPath = Environment.GetEnvironmentVariable("GOOGLE_CREDENTIALS_PATH");

            // conecta com o Google usando as credenciais
            var credential = GoogleCredential
                .FromFile(credentialsPath)
                .CreateScoped(SheetsService.Scope.Spreadsheets);

            // cria o serviço do Google Sheets
            _sheetsService = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "StudyReminderBot"
            });

            // ID da planilha (vamos configurar depois)
            _spreadsheetId = Environment.GetEnvironmentVariable("SPREADSHEET_ID");
        }

        // lê a aba Atividades e retorna uma lista de objetos Atividade
        public async Task<List<Atividade>> GetAtividadesAsync()
        {
            var range = "Atividades!A2:G100"; // agora vai até a coluna G
            var request = _sheetsService.Spreadsheets.Values.Get(_spreadsheetId, range);
            var response = await request.ExecuteAsync();
            var rows = response.Values;

            var atividades = new List<Atividade>();

            if (rows == null) return atividades;

            foreach (var row in rows)
            {
                atividades.Add(new Atividade
                {
                    Nome = row.Count > 0 ? row[0].ToString() : "",
                    Microfundamento = row.Count > 1 ? row[1].ToString() : "",
                    Pontuacao = row.Count > 2 ? row[2].ToString() : "",
                    DataLimite = row.Count > 3 ? DateTime.Parse(row[3].ToString()) : DateTime.MinValue,
                    Tipo = row.Count > 4 ? row[4].ToString() : "",
                    Link = row.Count > 5 ? row[5].ToString() : "",       // link da atividade
                    Enviado = row.Count > 6 ? row[6].ToString() : "Não" // agora é coluna G
                });
            }

            return atividades;
        }

        // lê a aba Integrantes e retorna uma lista de objetos Integrante
        public async Task<List<Integrante>> GetIntegrantesAsync()
        {
            var range = "Integrantes!A2:D100";
            var request = _sheetsService.Spreadsheets.Values.Get(_spreadsheetId, range);
            var response = await request.ExecuteAsync();
            var rows = response.Values;

            var integrantes = new List<Integrante>();

            if (rows == null) return integrantes;

            foreach (var row in rows)
            {
                integrantes.Add(new Integrante
                {
                    Nome = row.Count > 0 ? row[0].ToString() : "",
                    Numero = row.Count > 1 ? row[1].ToString() : "",
                    RecebeIndividual = row.Count > 2 ? row[2].ToString() : "Não",
                    RecebeGrupo = row.Count > 3 ? row[3].ToString() : "Não"
                });
            }

            return integrantes;
        }

        // lê a aba Destinos e retorna uma lista de objetos Destino
        public async Task<List<Destino>> GetDestinosAsync()
        {
            var range = "Destinos!A2:C100";
            var request = _sheetsService.Spreadsheets.Values.Get(_spreadsheetId, range);
            var response = await request.ExecuteAsync();
            var rows = response.Values;

            var destinos = new List<Destino>();

            if (rows == null) return destinos;

            foreach (var row in rows)
            {
                destinos.Add(new Destino
                {
                    Numero = row.Count > 0 ? row[0].ToString() : "",
                    Tipo = row.Count > 1 ? row[1].ToString() : "",
                    Ativo = row.Count > 2 ? row[2].ToString() : "Não"
                });
            }

            return destinos;
        }
    }
}