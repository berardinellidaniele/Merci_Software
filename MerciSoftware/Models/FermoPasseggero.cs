namespace MerciSoftware.Models
{
    public class FermoPasseggero
    {
        public int ID_Fermo { get; set; }
        public int ID_Controllo { get; set; }
        public int ID_Passeggero { get; set; }
        public DateTime data_ora_fermo { get; set; }
        public string motivo { get; set; }
        public string stato { get; set; }
    }
}
