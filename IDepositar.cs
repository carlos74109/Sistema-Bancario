namespace AplicativoBancario.Models
{
    internal interface IDepositar
    {
        void depositar(double deposito);

        void sacar(double sacar);

        double impostoRenda();
    }
}
