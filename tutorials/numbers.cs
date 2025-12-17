//Habilitação de uso de uma biblioteca
using static System.Math;

//Para o funcionamento de qualquer função deve-se deletar as '//' pois com esse caracteres a linha será ignorada pelo sistema

//WorkWithIntegers();
//OrderPrecedence();
//PecisonLimitsInt();
//WorkWithDouble();
//WorkWithDecimal();

void WorkWithIntegers()
{
    //Tipo de dado do tipo inteiro
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);
    //Operações
    Console.WriteLine($"a - b = {a - b}");
    Console.WriteLine($"a × b = {a * b}");
    Console.WriteLine($"a / b = {a / b}");
}

void OrderProcedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    //C# segue a regra de prioridades matemáticas
    int d = a + b * c;
    Console.WriteLine($"a + b * c = {d}");
    d = (a + b) * c;
    Console.WriteLine($"(a + b) * c = {d}");
    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine($"(a + b) - 6 * c + (12 * 4) / 3 + 12 = {d}");
    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine($"(e + f) / g = {d}");

}

void PrecisionLimitsInt()
{
    //Exploração de precisão e limites dos inteiros
    int a = 7;
    int b = 4;
    int c = 3;
    int d = (a + b) / c;
    int e = (a + b) % c;
    Console.WriteLine($"Cociênte: (a + b) /c = {d}");
    Console.WriteLine($"Resto: (a + b) % c = {e}");
    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"O interva dos números inteiros é de {min} até {max}");
    Console.WriteLine($"Um exemplo de um estouro do intervalo inteiro: {max + 2}.\nEsse valor é o mesmo que o valor mínimo mais 2, isso acontece porque como foi 'estourado' o valor máximo, o programa retorna ao valor mínimo e adiciona o valor pedido.");
}

void WorkWithDouble()
{
    //Números de pontos flutuante
    //Números de precisão dupla, double
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine($"(a + b) / c = {d}");
    a = 19;
    b = 23;
    c = 8;
    d = (a + b) / c;
    Console.WriteLine($"(a + b) / c = {d}");
    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"O intervalo dos número racionais vai de {min} até {max}");
    double third = 1.0 / 3.0;
    Console.WriteLine($"1/3 = {third}");
}

void WorkWithDecimal()
{
    //Tralhando com os tipos decimais
    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;
    Console.WriteLine($"O intervalo dos número decimais é de {min} até {max}");
    double a = 1.0;
    double b = 3.0;
    Console.WriteLine($"Calcula com double: 1/3 = {a / b}");
    //A letra M nos números é para dizer para o programa para continuar assumindo que os calculos com esse números sejam do tipo decimal
    decimal c = 1.0M;
    decimal d = 3.0M;
    Console.WriteLine($"Calcula com decimal: 1/3 = {c / d}");

    //Desafio: calculo de área de circula de raio 2,50 cm 
    double PI = Math.PI;
    double raio = 2.50;
    Console.WriteLine($"Um círculo de raio 2,5 cm tem área igual a {PI * (Math.Pow(raio, 2))} cm²");
}
