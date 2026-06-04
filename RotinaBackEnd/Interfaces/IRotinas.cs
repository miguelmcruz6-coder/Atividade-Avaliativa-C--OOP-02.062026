namespace RotinaBackEnd.Interfaces
{
    // Interface que define o contrato
    // obrigatório para qualquer rotina.
    public interface IRotina
    {
        // Método principal da rotina.
        void Executar();

        // Retorna uma descrição da rotina.
        string ObterDescricao();
    }
}