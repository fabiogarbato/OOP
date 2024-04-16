class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente("João Silva");
        Conta contaCorrente = new ContaCorrente("12345-6", 1000);
        Conta contaPoupanca = new ContaPoupanca("78910-1", 1500);

        cliente.AdicionarConta(contaCorrente);
        cliente.AdicionarConta(contaPoupanca);

        contaCorrente.Depositar(500);
        contaCorrente.Sacar(200);
        contaCorrente.ImprimirExtrato();

        contaPoupanca.Depositar(300);
        contaPoupanca.Sacar(100);
        contaPoupanca.ImprimirExtrato();
    }
}