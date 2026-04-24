namespace StudyReminderBot.Models
{
    public class Integrante
    {
        public string Nome { get; set; }              // nome do integrante
        public string Numero { get; set; }            // número do WhatsApp
        public string RecebeIndividual { get; set; }  // recebe notificação individual?
        public string RecebeGrupo { get; set; }       // recebe notificação em grupo?
    }
}