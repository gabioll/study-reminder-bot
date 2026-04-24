namespace StudyReminderBot.Models
{
    public class Destino
    {
        public string Numero { get; set; }  // número do grupo ou contato
        public string Tipo { get; set; }    // "Grupo" ou "Contato"
        public string Ativo { get; set; }   // "Sim" ou "Não"
    }
}