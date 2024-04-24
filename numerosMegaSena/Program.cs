
int size = 6;
int[] numerosOriginais = new int[size];
int[] numerosOrdenados = new int[size];
int aux = 0;

Console.WriteLine("Números sorteados: ");
for (int i = 0; i < size; i++)
{
    numerosOriginais[i] = new Random().Next(1, 60);

    for (int j = 1; j < size; j++)
    {
        if (numerosOriginais[i] == numerosOriginais[j])
        {
            numerosOriginais[i] = new Random().Next(1, 60);
        }
        numerosOrdenados[i] = numerosOriginais[i];
    }
    Console.Write(numerosOriginais[i] + " ");
}


for (int referencia = 0; referencia < size; referencia++)
{
    for (int comparacao = referencia + 1; comparacao < size; comparacao++)
    {
        if (numerosOrdenados[referencia] > numerosOrdenados[comparacao])
        {
            aux = numerosOrdenados[referencia];
            numerosOrdenados[referencia] = numerosOrdenados[comparacao];
            numerosOrdenados[comparacao] = aux;
        }
    }
}


Console.WriteLine("\n\nNúmeros ordenados: ");
Console.Write(numerosOrdenados[0] + " ");

for (int i = 1; i < size; i++)
{
    if (numerosOrdenados[i] != numerosOrdenados[i - 1])
    {
        Console.Write(numerosOrdenados[i] + " ");
    }
}
Console.ReadKey();



