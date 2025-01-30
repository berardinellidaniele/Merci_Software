namespace MerciSoftware.Models
{
    public class Passeggero
    {
        public int ID_Passeggero { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string nazionalita { get; set; }
        public string num_documento { get; set; }
        public string aeroporto_provenienza { get; set; }
        public string aeroporto_destinazione { get; set; }
        public string motivo_viaggio { get; set; }
    }
}
