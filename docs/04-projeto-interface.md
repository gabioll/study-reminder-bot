# Projeto de Interface

Por se tratar de um bot de notificações via WhatsApp, o projeto não possui uma interface visual tradicional com telas e fluxos de navegação. A interação com o sistema acontece em dois níveis:

## 1. Interface do Administrador — Google Sheets

O administrador gerencia todas as informações do bot diretamente pela planilha do Google Sheets, que funciona como o painel de controle do sistema. A planilha é organizada em três abas:

### Aba — Atividades

| Atividade | Microfundamento | Pontuação | Data Limite | Tipo | Gabrielly | Colega 1 | Colega 2 |
|---|---|---|---|---|---|---|---|
| Trabalho 1 | Dev Web | 10 pts | 20/04/2026 | Entrega | ✅ Concluído | ⏳ Pendente | ⏳ Pendente |
| Prova 1 | Banco de Dados | 20 pts | 25/04/2026 | Prova | ⏳ Pendente | ⏳ Pendente | ⏳ Pendente |

### Aba — Integrantes

| Nome | Número | Recebe Individual | Recebe Grupo |
|---|---|---|---|
| Gabrielly | 5531999999999 | Sim | Sim |
| Colega 1 | 5531888888888 | Sim | Sim |
| Colega 2 | 5531777777777 | Não | Sim |

### Aba — Destinos

| Destino | Tipo | Ativo |
|---|---|---|
| 5531999999999 | Contato | Sim |
| 553199999999-group | Grupo | Sim |
| 5531888888888 | Contato | Não |

## 2. Interface do Membro do Grupo — WhatsApp

Os membros do grupo recebem as notificações automaticamente no WhatsApp, sem precisar acessar nenhuma plataforma externa. O formato das mensagens segue um padrão fixo:

### Notificação Semanal — Grupo
📚 Lembretes da Semana
📅 Semana: 14/04 a 20/04/2026
📌 Trabalho 1
Microfundamento: Desenvolvimento Web
Pontuação: 10 pts
Data Limite: 20/04/2026
Tipo: Entrega
📌 Prova 1
Microfundamento: Banco de Dados
Pontuação: 20 pts
Data Limite: 25/04/2026
Tipo: Prova
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

## Fluxo do Sistema

O fluxo de funcionamento do bot segue as seguintes etapas:

1. Administrador cadastra as atividades na planilha do Google Sheets
2. Bot lê a planilha diariamente no horário configurado
3. Bot verifica quais atividades estão próximas do prazo
4. Bot envia as notificações para os destinos configurados na aba Destinos
5. Bot registra na planilha que a notificação foi enviada com sucesso