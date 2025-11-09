/*1.Saudação com Nome 
Objetivo: Declarar variáveis, usar concatenação e interpolação. 
Descrição: Crie um script que declare uma variável para o nome de 
uma pessoa e exiba uma saudação personalizada, por exemplo: "Olá, 
João! Bem - vindo ao nosso site!". 
Dica: Utilize tanto a concatenação (.) quanto a interpolação dentro de 
uma string com aspas duplas.*/

Console.WriteLine("\nExercício 1\n");

string nome = "João";

// Usando concatenação
Console.WriteLine("Olá, " + nome + "! Bem-vindo ao nosso site!");

// Usando interpolação
Console.WriteLine($"Olá, {nome}! Que bom ver você por aqui!");



/*2. Conversão de Temperatura (Celsius para Fahrenheit) 
Objetivo: Trabalhar com cálculos matemáticos e variáveis. 
Descrição: Crie um script que converta uma temperatura em Celsius 
para Fahrenheit. A fórmula para conversão é:  
Dica: Declare uma constante para armazenar o valor 9/5 e faça o 
cálculo com a variável fornecida.*/

Console.WriteLine("\nExercício 2\n");

// 1. Declara a variável com a temperatura em Celsius
double celsius = 25.0;

// 2. Declara a constante para o valor 9/5
const double fator = 9.0 / 5.0;

// 3. Faz o cálculo da conversão
double fahrenheit = (celsius * fator) + 32;

// 4. Exibe o resultado
Console.WriteLine($"{celsius}°C equivalem a {fahrenheit}°F");



/*3.Impressão de Dados do Usuário 
Objetivo: Concatenar e interpolar dados. 
Descrição: Crie um script que solicite ao usuário seu nome, idade e 
cidade e depois mostre uma mensagem com essas informações. 
Exemplo: "Meu nome é João, tenho 25 anos e moro em São Paulo".
Dica: Use tanto concatenação quanto interpolação.*/


Console.WriteLine("\nExercício 3\n");


Console.Write("Digite seu nome: ");
string nomeUsuario = Console.ReadLine();

Console.Write("Digite sua idade: ");
int idadeUsuario = int.Parse(Console.ReadLine());

Console.Write("Digite sua cidade: ");
string cidadeUsuario = Console.ReadLine();

Console.WriteLine("\nMeu nome é " + nomeUsuario + ", tenho " + idadeUsuario + " anos e moro em " + cidadeUsuario + ".");
Console.WriteLine($"Meu nome é {nomeUsuario}, tenho {idadeUsuario} anos e moro em {cidadeUsuario}.");


/*4.Empréstimo Bancário
Objetivo: Cálculos financeiros e declaração de variáveis. 
Descrição: Crie um script que calcule o valor de uma parcela de um 
empréstimo, dado o valor total do empréstimo, a taxa de juros e o 
número de parcelas. Exemplo de fórmula:  
Dica: Utilize variáveis para o valor do empréstimo, a taxa de juros e o 
número de parcelas.*/

Console.WriteLine("\nExercício 4\n");


// Declaração das variáveis com valores fixos
double valorEmprestimo = 5000.00; // valor total do empréstimo
double taxaJuros = 0.02;          // taxa de juros (2% ao mês, por exemplo)
int numeroParcelas = 12;          // número de parcelas

// Cálculo da parcela (fórmula de juros compostos)
double parcela = (valorEmprestimo * Math.Pow(1 + taxaJuros, numeroParcelas) * taxaJuros) /
                 (Math.Pow(1 + taxaJuros, numeroParcelas) - 1);

// Exibição do resultado
Console.WriteLine("=== Simulação de Empréstimo ===");
Console.WriteLine($"Valor do empréstimo: R$ {valorEmprestimo:F2}");
Console.WriteLine($"Taxa de juros: {taxaJuros * 100}% ao mês");
Console.WriteLine($"Número de parcelas: {numeroParcelas}");
Console.WriteLine($"\nValor de cada parcela: R$ {parcela:F2}");



/*5. Conversor de Moeda 
Objetivo: Trabalhar com variáveis, operadores e arredondamento. 
Descrição: Crie um script que converta uma quantia em reais para 
dólares, com base em uma taxa de câmbio fornecida. Mostre o valor 
convertido com 2 casas decimais. 
Dica: Use round() para arredondar o valor para 2 casas decimais.*/

Console.WriteLine("\nExercício 5\n");

// Declaração das variáveis com valores fixos
double valorReais = 250.00;   // valor em reais
double taxaCambio = 5.25;     // 1 dólar = 5,25 reais
double valorDolares;

// Cálculo da conversão
valorDolares = valorReais / taxaCambio;

// Arredondamento para 2 casas decimais
valorDolares = Math.Round(valorDolares, 2);

// Exibição do resultado
Console.WriteLine("=== Conversor de Moeda ===");
Console.WriteLine($"Valor em reais: R$ {valorReais:F2}");
Console.WriteLine($"Taxa de câmbio: 1 dólar = R$ {taxaCambio:F2}");
Console.WriteLine($"\nValor convertido: US$ {valorDolares}");



/*6 . Calculadora de Desconto 
Objetivo: Cálculos matemáticos e uso de variáveis. 
Descrição: Crie um script que calcule o valor do desconto de um 
produto, dado o preço original e a porcentagem de desconto. Exemplo 
de fórmula:  
Dica: Use variáveis para armazenar o preço e a porcentagem do 
desconto e calcule o valor final.*/

Console.WriteLine("\nExercício 6\n");

// Declaração das variáveis com valores fixos
double precoOriginal = 200.00;      // preço do produto
double porcentagemDesconto = 15.0;  // desconto em %
double valorDesconto;
double precoFinal;

// Cálculo do valor do desconto
valorDesconto = precoOriginal * (porcentagemDesconto / 100);

// Cálculo do preço final
precoFinal = precoOriginal - valorDesconto;





