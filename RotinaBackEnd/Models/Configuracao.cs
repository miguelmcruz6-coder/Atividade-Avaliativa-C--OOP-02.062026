namespace RotinaBackEnd.Models
{
    public class Configuracao
    {
        public int LimiteMemoria { get; set; }

        public string PastaBackup { get; set; }

        public Configuracao()
        {
            LimiteMemoria = 80;
            PastaBackup = string.Empty;
        }
    }
}