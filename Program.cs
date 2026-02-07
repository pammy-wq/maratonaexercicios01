/*1. Saudação com Nome 
Objetivo: Declarar variáveis, usar concatenação e interpolação. 
Descrição: Crie uasdasdasdasdasdm script que declare uma variável para o nome de 
uma pessoa e exiba uma saudação personalizada.
*/
asdasd
Console.WriteLine("\n=== Exercício 1 ===\n");

string nomePessoa = "João Silva";
string saudacaoBase = "Bem-vindo ao nosso site";

// Usando concatenação
Console.WriteLine("Olá, " + nome + "! Bem-vindo ao nosso site!");

// Usando interpolação
Console.WriteLine($"Olá, {nomePessoa}! Esperamos que você aproveite a visita.");

dsdtenar e interpolar dados. 
*/

Console.WriteLine("\n=== Exercício 3 ===\n");

Console.Write("Digite seu nome: ");
string nomeUsuario = Console.ReadLine() ?? "Não informado";

Console.Write("Digite sua idade: ");
int idadeUsuario = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite sua cidade: ");
string cidadeUsuario = Console.ReadLine() ?? "Cidade desconhecida";

// Concatenação
Console.WriteLine("\nMeu nome é " + nomeUsuario + ", tenho " + idadeUsuario + " anos e moro em " + cidadeUsuario + ".");

// Interpolação
Console.WriteLine($"Resumo: {nomeUsuario}, {idadeUsuario} anos, residente em {cidadeUsuario}.");



/*4. Empréstimo Bancário
Objetivo: Cálculos financeiros e declaração de variáveis. 
*/

Console.WriteLine("\n=== Exercício 4 ===\n");

// Dados do empréstimo
double valorEmprestimo = 5000.00;
double taxaJurosMensal = 0.02;
int totalParcelas = 12;

// Cálculo da parcela (juros compostos)
double parcelaMensal =
    (valorEmprestimo * Math.Pow(1 + taxaJurosMensal, totalParcelas) * taxaJurosMensal) /
    (Math.Pow(1 + taxaJurosMensal, totalParcelas) - 1);

// Exibição detalhada
Console.WriteLine("=== Simulação de Empréstimo ===");
Console.WriteLine($"Valor solicitado: R$ {valorEmprestimo:F2}");
Console.WriteLine($"Juros mensais: {taxaJurosMensal * 100:F2}%");
Console.WriteLine($"Quantidade de parcelas: {totalParcelas}");
Console.WriteLine($"Parcela estimada: R$ {parcelaMensal:F2}");



/*5. Conversor de Moeda 
Objetivo: Trabalhar com variáveis, operadores e arredondamento. 
*/

Console.WriteLine("\n=== Exercício 5 ===\n");

// Valores base
double valorEmReais = 250.00;
double cotacaoDolar = 5.25;

// Conversão
double valorConvertidoDolar = valorEmReais / cotacaoDolar;
valorConvertidoDolar = Math.Round(valorConvertidoDolar, 2);

// Resultado
Console.WriteLine("=== Conversão de Moeda ===");
Console.WriteLine($"Reais: R$ {valorEmReais:F2}");
Console.WriteLine($"Cotação atual: R$ {cotacaoDolar:F2}");
Console.WriteLine($"Dólares: US$ {valorConvertidoDolar:F2}");



/*6. Calculadora de Desconto 
Objetivo: Cálculos matemáticos e uso de variáveis. 
*/

Console.WriteLine("\n=== Exercício 6 ===\n");

// Informações do produto
double precoOriginal = 200.00;
double descontoPercentual = 15.0;

// Cálculos
double valorDesconto = precoOriginal * (descontoPercentual / 100);
double precoComDesconto = precoOriginal - valorDesconto;

// Exibição final
Console.WriteLine("=== Detalhes do Desconto ===");
Console.WriteLine($"Preço original: R$ {precoOriginal:F2}");
Console.WriteLine($"Desconto aplicado: {descontoPercentual}%");
Console.WriteLine($"Valor do desconto: R$ {valorDesconto:F2}");
Console.WriteLine($"Preço final: R$ {precoComDesconto:F2}");