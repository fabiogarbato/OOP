public interface IConta
{
    string NumeroConta { get; }
    double Saldo { get; }
    void Depositar(double valor);
    void Sacar(double valor);
    void ImprimirExtrato();
}

public interface IGerenciadorTransacoes
{
    void RegistrarTransacao(double valor, string tipo);
    void ImprimirHistorico();
}
