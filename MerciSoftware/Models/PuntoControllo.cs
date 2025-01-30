namespace MerciSoftware.Models
{
    public class PuntoControllo
    {
        public int ID_PuntoControllo { get; set; }
        public int ID_Aeroporto { get; set; }
        public string nome { get; set; }
        public string descrizione { get; set; }
        public string localizzazione { get; set; }
    }
}
