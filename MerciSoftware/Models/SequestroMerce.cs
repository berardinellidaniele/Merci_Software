namespace MerciSoftware.Models
{
    public class SequestroMerce
    {
        public int ID_Sequestro { get; set; }
        public int ID_Controllo { get; set; }
        public int ID_Merce { get; set; }
        public string motivo { get; set; }
        public string stato { get; set; }
    }
}
