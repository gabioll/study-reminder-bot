namespace StudyReminderBot.Models  // pasta/organização do projeto
{
    public class Atividade  // criando a classe
    {
        public string Nome { get; set; }           // nome da atividade
        public string Microfundamento { get; set; } // qual matéria
        public string Pontuacao { get; set; }       // quantos pontos vale
        public DateTime DataLimite { get; set; }    // data de entrega
        public string Tipo { get; set; }            // prova ou entrega
        public string Link { get; set; }            // link da atividade no Canvas
        public string Enviado { get; set; }         // já foi notificado?
    }
}