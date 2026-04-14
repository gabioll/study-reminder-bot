# Introdução

A vida universitária impõe aos estudantes uma rotina intensa de atividades, prazos e avaliações. Uma rotina elevada de leituras e avaliações, prazos mais rígidos para entrega de trabalhos e um maior número de atividades extracurriculares são elementos que costumam interferir na organização do tempo dos estudantes (MacCann, Fogarty & Roberts, 2012).

Dados indicam que 56,1% dos estudantes brasileiros enfrentam alguma dificuldade que interfere na vida e/ou contexto acadêmico ao longo do período de graduação (SciELO Preprints, 2022). Entre os desafios mais comuns está a gestão do tempo e o acompanhamento de prazos, especialmente para estudantes que conciliam a faculdade com o trabalho.

Reforça-se a necessidade de promover ações que instrumentalizem os estudantes a gerenciar a vida acadêmica, de modo que consigam organizar sua agenda, manejar o tempo de maneira equilibrada, estabelecer uma rotina de estudo e cumprir prazos (PePSIC, 2018).

A proposta deste projeto é desenvolver um bot integrado ao WhatsApp capaz de enviar lembretes automáticos de atividades, provas e prazos para grupos universitários, centralizando as informações em uma planilha compartilhada no Google Sheets e automatizando a comunicação entre os integrantes do grupo.

## Problema

A gestão de atividades acadêmicas em grupo é marcada pela fragmentação das informações e pela dependência de comunicação manual. Prazos de entrega, datas de provas e tarefas do projeto frequentemente são compartilhados via mensagens avulsas no WhatsApp, sem organização centralizada, o que gera esquecimentos e desencontros entre os integrantes.

Nesse cenário, os problemas podem ser categorizados em dois eixos principais:

### 1. Acesso Passivo às Informações

O Canvas disponibiliza as atividades, porém depende que o aluno acesse a plataforma regularmente para visualizá-las. Na prática, muitos estudantes só percebem um prazo quando já está próximo ou até mesmo após o vencimento, especialmente em semanas com muitas entregas simultâneas de diferentes microfundamentos.

### 2. Ausência de Notificação Proativa

Não existe um mecanismo que entregue as informações diretamente ao aluno, de forma resumida e acessível, no canal de comunicação que ele já utiliza no dia a dia. A dependência de lembretes manuais entre os integrantes do grupo gera sobrecarga e falhas de comunicação.

Portanto, o problema central reside na ausência de uma ferramenta que notifique o grupo de forma automática e proativa diretamente no WhatsApp, consolidando informações como atividades da semana, pontuação, microfundamento correspondente e data limite de entrega, sem exigir que o aluno acesse plataformas externas ativamente.

## Objetivos

O sistema visa reduzir o índice de esquecimentos e atrasos acadêmicos por meio de um bot automatizado que entrega informações relevantes diretamente no WhatsApp do grupo, sem depender do acesso ativo a plataformas externas.

Como objetivos específicos, podemos destacar:

- **Automatizar o envio de lembretes:** Notificar o grupo semanalmente e/ou mensalmente sobre atividades a entregar, provas e prazos importantes.
- **Centralizar o cadastro de atividades:** Utilizar uma planilha compartilhada no Google Sheets para registrar atividades, microfundamentos, pontuações e datas limite de forma organizada e acessível a todos.
- **Informar de forma clara e objetiva:** Cada lembrete deve conter o nome da atividade, microfundamento correspondente, pontuação e data limite de entrega.
- **Integrar ao WhatsApp:** Utilizar a Evolution API para envio automático das mensagens diretamente no grupo já utilizado pela equipe.
- **Hospedar em nuvem:** Garantir o funcionamento contínuo do bot sem depender de equipamentos locais, por meio de hospedagem no Railway.
- **Permitir configuração de destinos:** Possibilitar o envio para grupos ou contatos individuais, configurável diretamente na planilha.

## Justificativa

A ideia deste projeto surgiu da vivência pessoal com os desafios da rotina universitária. Mesmo com o Canvas disponibilizando as atividades e prazos, os integrantes do grupo ainda enfrentavam esquecimentos e entregas atrasadas, pois a plataforma exige acesso ativo e não notifica de forma proativa no canal de comunicação que a equipe já utiliza no dia a dia.

Estudantes ansiosos que possuem dificuldade para se organizar e manter uma rotina de estudos, e aqueles que estudam e trabalham sentem-se sobrecarregados, o que afeta diretamente o desempenho acadêmico (Imperatriz Notícias, 2022).

Diante disso, desenvolver um bot que entregue automaticamente no WhatsApp do grupo um resumo das atividades da semana — com nome, microfundamento, pontuação e data limite — representa uma solução simples, prática e diretamente aplicável à realidade vivenciada, ao mesmo tempo em que permite aplicar e desenvolver conhecimentos em programação C#.

## Público-Alvo

O público-alvo principal são estudantes universitários que fazem parte de grupos de trabalho e precisam acompanhar prazos, atividades e datas importantes ao longo do semestre letivo, especialmente aqueles que conciliam a faculdade com outras responsabilidades como o trabalho.

O bot foi desenvolvido inicialmente para atender o grupo do curso de Análise e Desenvolvimento de Sistemas da PUC Minas, porém pode ser adaptado para qualquer grupo universitário que utilize o WhatsApp como canal de comunicação principal.

Os destinatários das notificações podem ser configurados de forma flexível, permitindo o envio tanto para grupos do WhatsApp quanto para contatos individuais, conforme a necessidade de cada usuário.