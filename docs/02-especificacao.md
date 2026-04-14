# Especificação do Projeto

## Perfis de Usuários

### Perfil 1 — Administrador

| | |
|---|---|
| **Descrição** | Estudante responsável por cadastrar e manter as atividades na planilha do Google Sheets, configurar os destinos de envio e garantir que as informações estejam sempre atualizadas. Possui conhecimento básico em tecnologia e é o principal responsável pela manutenção do bot. |
| **Necessidades** | Cadastrar atividades com nome, microfundamento, pontuação e data limite. Configurar para quais grupos ou contatos as notificações serão enviadas. Ativar ou desativar destinos de envio sem precisar mexer no código. Garantir que o bot esteja funcionando corretamente. |

### Perfil 2 — Membro do Grupo

| | |
|---|---|
| **Descrição** | Estudante que recebe as notificações automáticas no WhatsApp. Não precisa acessar nenhuma plataforma externa, apenas recebe os lembretes diretamente no grupo ou no contato pessoal. |
| **Necessidades** | Receber lembretes automáticos com as atividades da semana. Visualizar de forma clara o nome da atividade, microfundamento, pontuação e data limite. Ser notificado com antecedência suficiente para organizar a rotina de estudos. |

## Histórias de Usuários

| EU COMO... | QUERO/PRECISO... | PARA... |
|---|---|---|
| Administrador | Cadastrar atividades na planilha | Manter as informações sempre atualizadas para o grupo |
| Administrador | Configurar os destinos de envio | Escolher se a notificação vai para o grupo ou contatos individuais |
| Administrador | Ativar ou desativar destinos | Controlar quem recebe as notificações sem mexer no código |
| Membro do Grupo | Receber lembretes automáticos no WhatsApp | Não esquecer prazos e atividades importantes |
| Membro do Grupo | Visualizar nome, microfundamento, pontuação e data limite | Ter todas as informações necessárias em uma única mensagem |
| Membro do Grupo | Marcar uma atividade como concluída | Parar de receber lembretes de atividades que já finalizei |
| Membro do Grupo | Receber notificações individuais no privado | Acompanhar meus próprios prazos separadamente do grupo |
| Administrador | Visualizar quem já concluiu cada atividade | Acompanhar o progresso do grupo |
| Membro do Grupo | Receber notificações com antecedência | Me organizar com tempo suficiente para entregar as atividades |
| Administrador | Receber confirmação de envio | Saber que o bot funcionou corretamente |

## Requisitos Funcionais

| ID | Descrição | Prioridade |
|---|---|---|
| RF-01 | O sistema deve ler automaticamente as atividades, integrantes e destinos cadastrados na planilha do Google Sheets. | Alta |
| RF-02 | O sistema deve enviar notificações automáticas via WhatsApp com as atividades da semana e do mês. | Alta |
| RF-03 | Cada notificação deve conter o nome da atividade, microfundamento, pontuação e data limite. | Alta |
| RF-04 | O sistema deve enviar notificações tanto para grupos quanto para contatos individuais, conforme configurado na planilha. | Alta |
| RF-05 | O sistema deve permitir ativar ou desativar destinos de envio sem necessidade de alteração no código. | Alta |
| RF-06 | O sistema deve verificar diariamente os prazos e enviar alertas quando uma atividade estiver próxima do vencimento. | Alta |
| RF-07 | O sistema deve permitir que cada integrante marque sua atividade como concluída, interrompendo os lembretes para aquela pessoa. | Alta |
| RF-08 | O sistema deve registrar na planilha se a notificação foi enviada com sucesso. | Média |
| RF-09 | O sistema deve funcionar de forma contínua, hospedado em nuvem, sem depender de equipamentos locais. | Alta |

## Requisitos Não Funcionais

| ID | Descrição | Prioridade |
|---|---|---|
| RNF-01 | O sistema deve ser desenvolvido em C# utilizando .NET 8. | Alta |
| RNF-02 | O sistema deve garantir disponibilidade contínua por meio de hospedagem no Railway. | Alta |
| RNF-03 | O sistema deve enviar as notificações em no máximo 1 minuto após o horário configurado. | Alta |
| RNF-04 | O sistema deve manter as credenciais de acesso protegidas por variáveis de ambiente, nunca expostas no código. | Alta |
| RNF-05 | O sistema deve ser de fácil manutenção, permitindo atualizações apenas pela planilha sem alterar o código. | Alta |