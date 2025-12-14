//Testes com variáveis
string name = "Karol";
Console.WriteLine("Welcome again " + name);
string aFriend = "to Bill";
Console.WriteLine("-" + aFriend);
aFriend = "Mike";

//Testes de variáveis no console
Console.WriteLine("AND " + aFriend + ", too!");
Console.WriteLine($"\nEm C# usamos variáveis para armazenar informações como o nome '{name}',");
Console.WriteLine("Para podermos roda-las no terminal usamos o  comando 'Console.WriteLine(), a qual recebe em sua aspas um parametro que irá aparecer na tela.'");
Console.WriteLine("Ademais o uso do caractere '+' é responsável pela concatenação das mensagens em string e as variáveis. Como também usamos o '$' para essa mesma função no começo do parametro para simplificar essa ligação. (exemplos dentro do código).");

//Funções básicas de modificação de String's
//.Length
Console.WriteLine($"\nString internal functions: Length (mensure the length of the string and return the number of caracters) example: name.length /name ='Karol'/, return the number {name.Length}.");
String greeting ="         Hello people!    ";
//.Trim()
Console.WriteLine($"\nO comando Trim() retira qualquer espaço de uma string, um exemplo é greeting = '         Hello people!    ' que submetido a essafunção passa a ter o formato de '{greeting.Trim()}'");
//.TrimStart()
Console.WriteLine($"\nO comado TrimStart() retira qualquer espaço do começo da string, podendo transformar a variável passa a ter esse formato '{greeting.TrimStart()}'");
//TrimEnd()
Console.WriteLine($"\nPor fim dos comandos Trim, TrimEnd() retira os espaços do final da string transformando em '{greeting.TrimEnd()}'");
Console.WriteLine($"\nCapeta");