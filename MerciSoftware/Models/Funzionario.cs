namespace MerciSoftware.Models
{
    public class Funzionario
    {
        public int ID_Funzionario { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Ruolo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? ID_Addetto { get; set; }
        public int? ID_PuntoControllo { get; set; }
    }
}
