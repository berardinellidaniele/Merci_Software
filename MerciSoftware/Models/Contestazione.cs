namespace MerciSoftware.Models
{
    public class Contestazione
    {
        public int ID_Contestazione { get; set; }
        public int ID_Controllo { get; set; }
        public DateTime data_ora_contestazione { get; set; }
        public string motivo { get; set; }
        public string stato { get; set; }
    }
}
