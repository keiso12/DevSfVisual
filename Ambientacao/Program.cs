int tamanho = 10;
int[] vetor = new int[tamanho];
Random random = new();

Console.Clear();

for (int i = 0; i < tamanho; i++){
    vetor[i] = random.Next(0, 500);
}

// Array.Sort(vetor);
int aux = 0;
bool troca = false;

do
{
    troca = false;
    for (int i = 0; i < tamanho - 1; i++)
    {
        if(vetor[i] > vetor[i + 1]){

            aux = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = aux;
            troca = true;
        
        }
    }
} while (troca);

imprimirVetor();

void imprimirVetor(){
    for (int i = 0; i < tamanho; i++)
    {
        Console.Write(vetor[i]+" ");
    }
}

