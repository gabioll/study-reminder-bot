Abre o 06-programacao-funcionalidades.md e cola esse conteúdo:

markdown# Programação de Funcionalidades

Implementação da aplicação descrita por meio dos requisitos codificados.

## 1. Leitura da Planilha do Google Sheets

**Responsável:** Gabrielly Araujo

O bot acessa a planilha do Google Sheets por meio da Google Sheets API e lê as abas de Atividades, Integrantes e Destinos para obter as informações necessárias para o envio das notificações.

**Requisitos atendidos**
- RF-01: O sistema deve ler automaticamente as atividades, integrantes e destinos cadastrados na planilha do Google Sheets.

**Artefatos da funcionalidade**
- `GoogleSheetsService.cs`

**Instruções de acesso**
A planilha é acessada automaticamente pelo bot a cada execução diária. O administrador pode atualizar as informações diretamente na planilha do Google Sheets sem necessidade de alteração no código.

---

## 2. Envio de Notificações para o Grupo

**Responsável:** Gabrielly Araujo

O bot envia automaticamente uma mensagem no grupo do WhatsApp com todas as atividades da semana que ainda possuem pelo menos um integrante com status pendente.

**Requisitos atendidos**
- RF-02: O sistema deve enviar notificações automáticas via WhatsApp com as atividades da semana e do mês.
- RF-03: Cada notificação deve conter o nome da atividade, microfundamento, pontuação e data limite.
- RF-04: O sistema deve enviar notificações tanto para grupos quanto para contatos individuais, conforme configurado na planilha.

**Artefatos da funcionalidade**
- `WhatsAppService.cs`
- `NotificationService.cs`

**Instruções de acesso**
O envio ocorre automaticamente no horário configurado. O administrador pode configurar o destino do grupo na aba **Destinos** da planilha.

---

## 3. Envio de Notificações Individuais

**Responsável:** Gabrielly Araujo

O bot envia notificações personalizadas no privado de cada integrante, exibindo apenas as atividades que ainda estão pendentes para aquela pessoa especificamente.

**Requisitos atendidos**
- RF-04: O sistema deve enviar notificações tanto para grupos quanto para contatos individuais, conforme configurado na planilha.
- RF-07: O sistema deve permitir que cada integrante marque sua atividade como concluída, interrompendo os lembretes para aquela pessoa.

**Artefatos da funcionalidade**
- `WhatsAppService.cs`
- `NotificationService.cs`
- `Integrante.cs`

**Instruções de acesso**
Cada integrante cadastrado na aba **Integrantes** com a coluna **Recebe Individual** marcada como **Sim** receberá automaticamente sua notificação personalizada.

---

## 4. Controle de Atividades Concluídas

**Responsável:** Gabrielly Araujo

Cada integrante pode marcar sua atividade como concluída diretamente na planilha. O bot verifica esse status antes de cada envio e não notifica integrantes que já concluíram a atividade.

**Requisitos atendidos**
- RF-07: O sistema deve permitir que cada integrante marque sua atividade como concluída, interrompendo os lembretes para aquela pessoa.

**Artefatos da funcionalidade**
- `GoogleSheetsService.cs`
- `Atividade.cs`

**Instruções de acesso**
Na aba **Atividades** da planilha, cada integrante altera seu status de **⏳ Pendente** para **✅ Concluído** quando finalizar a atividade.

---

## 5. Alerta de Prazo Próximo

**Responsável:** Gabrielly Araujo

O bot verifica diariamente os prazos cadastrados e envia um alerta especial quando uma atividade está próxima do vencimento, tanto no grupo quanto no privado dos integrantes com status pendente.

**Requisitos atendidos**
- RF-06: O sistema deve verificar diariamente os prazos e enviar alertas quando uma atividade estiver próxima do vencimento.

**Artefatos da funcionalidade**
- `NotificationService.cs`
- `Worker.cs`

**Instruções de acesso**
O bot verifica automaticamente todos os dias. Atividades com prazo em até 2 dias recebem notificação de alerta especial.

---

## 6. Configuração de Destinos de Envio

**Responsável:** Gabrielly Araujo

O administrador configura os destinos de envio diretamente na aba **Destinos** da planilha, podendo ativar ou desativar grupos e contatos individuais sem necessidade de alteração no código.

**Requisitos atendidos**
- RF-05: O sistema deve permitir ativar ou desativar destinos de envio sem necessidade de alteração no código.

**Artefatos da funcionalidade**
- `GoogleSheetsService.cs`
- `Destino.cs`

**Instruções de acesso**
Na aba **Destinos** da planilha, o administrador altera a coluna **Ativo** para **Sim** ou **Não** conforme necessário.

---

## 7. Registro de Envio

**Responsável:** Gabrielly Araujo

Após cada envio, o bot registra na planilha se a notificação foi enviada com sucesso, permitindo que o administrador acompanhe o funcionamento do sistema.

**Requisitos atendidos**
- RF-08: O sistema deve registrar na planilha se a notificação foi enviada com sucesso.

**Artefatos da funcionalidade**
- `GoogleSheetsService.cs`
- `NotificationService.cs`

**Instruções de acesso**
O registro é feito automaticamente na aba **Atividades**, na coluna **Enviado**, após cada notificação bem-sucedida.