List<string> nome = new List<string>();
List<int> ordem = new List<int>();
List<string> ordemRng = new List<string>();
List<string> ordemFinal = new List<string>();
Random rand = new Random();
int teste = 0;
int rng;
int numN = 1;
int numO = 1;
int numlist = 1;

string numteste;
bool comparacao;
bool repete;

Console.WriteLine("Olá, usuário!");
Console.WriteLine("Neste programa você criará duas listas cujo conteúdo você decide!");
Console.WriteLine("A primeira lista será a base e cada item dela deverá ser único.");
Console.WriteLine("A segunda lista será composta por itens da primeira, mas, em uma " +
    "ordem que você digitar!");
Console.WriteLine("Detalhe: a lista começa no 0.");
Console.WriteLine("");
Console.WriteLine("Após isso o programa irá gerar listas aleatórias até atingir a" +
    " ordem da segunda lista, e depois dirá quantas tentativas foram necessárias para atingi-la.");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Vamos começar!");
Console.WriteLine("Digite o número de quantas coisas terão na primeira lista:");
for (int i = 0; i < 1; i++)
{
    numteste = Console.ReadLine();
    if (int.TryParse(numteste, out numN))
    {
        //valor declarado
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Digite um número!");
        Console.WriteLine("");
        i--;
    }
}

for (int i = 0; i < numN; i++) //escrever os nomes
{
    Console.WriteLine("");
    Console.WriteLine("Digite o conteúdo de número " + i);
    numteste = Console.ReadLine();
    if (string.IsNullOrEmpty(numteste))
    {
        Console.WriteLine("");
        Console.WriteLine("Não pode ficar em branco, digite algo!");
        Console.WriteLine("");
        i--;        
    } else
    {
        nome.Add(numteste);
    }
}

Console.WriteLine("");
Console.WriteLine("Agora, digite o número de quantas coisas terão na segunda lista:");
for (int i = 0; i < 1; i++)
{
    numteste = Console.ReadLine();
    if(int.TryParse(numteste, out numO))
    {
        //valor declarado
    } else
    {
        Console.WriteLine("");
        Console.WriteLine("Digite um número!");
        Console.WriteLine("");
        i--;
    }

}


Console.WriteLine("");
Console.WriteLine("Dada a lista abaixo, digite a ordem que a segunda lista deva seguir: ");
for (int i = 0; i < numN; i++) // exibir numero relativo a ordem
{
    Console.WriteLine(i+" = "+ nome[i]);
}


for (int i = 0; i < numO; i++)
{
    Console.WriteLine("");
    Console.WriteLine("Digite o elemento de número "+i+" da segunda lista: ");
    numteste = Console.ReadLine();
    if (int.TryParse(numteste, out numlist) && int.Parse(numteste)< numN)
    {
        ordem.Add(numlist);
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Valor inválido!");
        Console.WriteLine("");
        i--;
    }
}

for (int i = 0; i < numO; i++) //lista pronta
{
    ordemFinal.Add(nome[ordem[i]]);
}
do
{
    teste++;
    Console.WriteLine("");
    Console.WriteLine("Tentativa número " + teste);
    ordemRng.Clear();
    for (int i = 0; i < numO; i++)
    {
    rng = rand.Next(nome.Count);
    ordemRng.Add(nome[rng]);
    }
    for (int i = 0; i < numO; i++) //mostrar lista
    {
        Console.WriteLine(i +" = "+ ordemRng[i]);
    }
    comparacao = ordemFinal.SequenceEqual(ordemRng);
} while (comparacao != true);
Console.WriteLine("");
Console.WriteLine("O resultado foi atingido na tentativa número "+ teste +".");

Console.ReadLine();