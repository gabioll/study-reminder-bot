markdown# Template Padrão da Aplicação

Por se tratar de um bot de notificações, o projeto não possui interface visual com telas ou layouts. O template padrão da aplicação é definido pelo formato das mensagens enviadas via WhatsApp e pela estrutura da planilha no Google Sheets.

## Identidade Visual das Mensagens

As mensagens seguem um padrão fixo de formatação, utilizando emojis para facilitar a leitura e destacar as informações mais importantes. O formato é consistente em todos os tipos de notificação:

### Notificação Semanal — Grupo
📚 Lembretes da Semana
📅 Semana: 14/04 a 20/04/2026
📌 Trabalho 1
Microfundamento: Desenvolvimento Web
Pontuação: 10 pts
Data Limite: 20/04/2026
Tipo: Entrega
⚠️ Fique atento aos prazos!

### Notificação Individual — Privado
👤 Seus lembretes da semana, Gabrielly!
📅 Semana: 14/04 a 20/04/2026
📌 Trabalho 1
Microfundamento: Desenvolvimento Web
Pontuação: 10 pts
Data Limite: 20/04/2026
Status: ⏳ Pendente
✅ Você já concluiu 0 de 2 atividades essa semana.
⚠️ Fique atento aos prazos!

### Notificação de Prazo Próximo
🚨 Atenção! Prazo se aproximando!
📌 Trabalho 1
Microfundamento: Desenvolvimento Web
Pontuação: 10 pts
Data Limite: amanhã (20/04/2026)
⏰ Não deixe para a última hora!

## Estrutura de Codificação

O projeto é organizado nas seguintes pastas:
study-reminder-bot/
├── docs/                        # Documentação do projeto
│   ├── 01-introducao.md
│   ├── 02-especificacao.md
│   ├── 03-metodologia.md
│   ├── 04-projeto-interface.md
│   ├── 05-template-padrao.md
│   ├── 06-programacao-funcionalidades.md
│   └── 07-referencias.md
├── src/                         # Código fonte
│   ├── Worker.cs                # Serviço em background
│   ├── Program.cs               # Ponto de entrada
│   ├── Services/
│   │   ├── GoogleSheetsService.cs   # Leitura da planilha
│   │   ├── WhatsAppService.cs       # Envio de mensagens
│   │   └── NotificationService.cs  # Lógica de notificações
│   └── Models/
│       ├── Atividade.cs         # Modelo de atividade
│       ├── Integrante.cs        # Modelo de integrante
│       └── Destino.cs           # Modelo de destino
└── study-reminder-bot.csproj