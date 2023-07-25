namespace SolucaoExercicio01.Classes
{
    public class ContaCorrente : Conta, ITributo
    {
        public ContaCorrente(int agencia, int numero) : base(agencia, numero)
        {
        }

        public double CalcularTributos()
        {
            return Saldo * 0.1;
        }
    }
}