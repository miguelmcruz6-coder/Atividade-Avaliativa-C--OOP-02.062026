namespace RotinaBackEnd.Models
{
    // Modelo que armazena as configurações da aplicação
    public class Configuracao
    {
        // Limite percentual de uso de memória para emissão de alerta
        public int LimiteMemoria { get; set; }

        // Caminho da pasta utilizada para armazenar backups
        public string PastaBackup { get; set; }

        public Configuracao()
        {
            // Valor padrão para alerta de memória
            LimiteMemoria = 80;

            // Inicializa a pasta de backup vazia
            PastaBackup = string.Empty;
        }
    }
}