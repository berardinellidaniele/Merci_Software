namespace MerciSoftware.Models
{
    public class Controllo
    {
        public int ID_Controllo { get; set; }
        public int ID_Addetto { get; set; }
        public int ID_Passeggero { get; set; }
        public int ID_PuntoControllo { get; set; }
        public int punto_controllo { get; set; }
        public DateTime dataora_inizio { get; set; }
        public DateTime dataora_fine { get; set; }
        public string esito { get; set; }
        public string note { get; set; }
        public float dazio_doganale { get; set; }
    }
}
