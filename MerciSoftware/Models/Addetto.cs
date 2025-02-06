namespace MerciSoftware.Models
{
    public class Addetto
    {
        public int ID_Addetto { get; set; }
        public int ID_PuntoControllo { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public DateTime data_nascita { get; set;    }
    }
}
