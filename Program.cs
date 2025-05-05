// Um cliente quer solicitar um empréstimo. Receba o valor solicitado, a quantidade de parcelas desejada e a renda mensal comprovada. 
// Só autorize empréstimos cuja parcela não ultrapasse 30% da renda (desconsidere os juros).

Console.Clear();
Console.WriteLine("Empréstimo Pessoal 💰\n");

Console.Write("Digite o valor do empréstimo solicitado: ");
bool valorValido = double.TryParse(Console.ReadLine(), out double valorEmprestimo);

Console.Write("Digite a quantidade de parcelas desejada: ");
bool parcelasValidas = int.TryParse(Console.ReadLine(), out int quantidadeParcelas);

Console.Write("Digite a renda mensal comprovada: ");
bool rendaValida = double.TryParse(Console.ReadLine(), out double rendaMensal);

if (!valorValido || !parcelasValidas || !rendaValida ||
valorEmprestimo <= 0 || quantidadeParcelas <= 0 || rendaMensal <= 0)
{
    Console.WriteLine();
    Console.WriteLine("Insira valores numéricos válidos e maiores que zero.");
}
else
{
    double valorParcela = valorEmprestimo / quantidadeParcelas;
    double limiteParcela = rendaMensal * 0.3;

    Console.WriteLine($"\nValor da parcela: R$ {valorParcela:F2}");
    Console.WriteLine($"Limite permitido (30% da renda): R$ {limiteParcela:F2}");

    if (valorParcela <= limiteParcela)
    {
        Console.WriteLine();
        Console.WriteLine("Empréstimo autorizado! ✅");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("A parcela ultrapassa 30% da renda mensal. ");
        Console.WriteLine("Empréstimo não autorizado! ❌");
    }
}