namespace MerciSoftware.Models
{
    public class Segnalazione
    {
        public int ID_Segnalazione { get; set; }
        public int ID_Controllo { get; set; }
        public string tipologia { get; set; }
        public string stato { get; set; }
    }
}
