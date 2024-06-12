using Inheritance.Model;

try
{

    Cliente titular1 = new Cliente("Victor", "12345678910", 1997, "victor@teste.com");

    Conta contaCorrente = new Conta(12345, 2000m, titular1);
    contaCorrente.Deposito(500m);
    Console.WriteLine($"Saldo após depósito: {contaCorrente.Saldo}");
    contaCorrente.Saque(300m);
    Console.WriteLine($"Saldo após saque: {contaCorrente.Saldo}");

    // Criando uma conta especial
    ContaEspecial contaEspecial = new ContaEspecial(54321, 500m, 1000m, titular1);
    contaEspecial.Deposito(500m);
    Console.WriteLine($"Saldo após depósito: {contaEspecial.Saldo}");
    contaEspecial.Saque(300m);
    Console.WriteLine($"Saldo após saque: {contaEspecial.Saldo}");

    // Transferência entre contas
    contaCorrente.Transferir(200m, contaEspecial);
    Console.WriteLine($"Saldo conta corrente após transferência: {contaCorrente.Saldo}");
    Console.WriteLine($"Saldo conta especial após receber transferência: {contaEspecial.Saldo}");

}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}