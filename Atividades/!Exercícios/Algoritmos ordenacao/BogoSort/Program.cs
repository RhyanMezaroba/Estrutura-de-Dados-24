using System;

class Program
{
    // Método principal onde o BogoSort é executado
    static void Main()
    {
        // Array de exemplo para ordenar
        int[] array = { 3, 1, 4, 2 };
        Console.WriteLine("Array original: " + string.Join(", ", array));

        // Executa o BogoSort no array
        BogoSort(array);

        // Exibe o Array Ordenado
        Console.WriteLine("Array ordenado: " + string.Join(", ", array));
    }

    // Função que realiza o algoritmo BogoSort
    static void BogoSort(int[] array)
    {
        // Continua embaralhando até que o array esteja ordenado
        while (!IsSorted(array))
        {
            Shuffle(array);

            // Exibe o array após cada tentativa de embaralhamento
            PrintArray(array); 
        }
    }

    // Método que verifica se o array está ordenado
    static bool IsSorted(int[] array)
    {
        // Percorre o array para verificar se todos os elementos estão em ordem crescente
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                // Retorna flaso se encontrar um elemento fora de ordem
                return false;
            }
        }
        // Retorna verdadeiro se o array estiver ordenado
        return true;
    }

    // Método que embaralha o array de forma aleatória
    static void Shuffle(int[] array)
    {
        Random rand = new Random();
        
        // Para cada elementodo array, troca com outro elemento aleatório
        for (int i = 0; i < array.Length; i++)
        {
            int randomIndex = rand.Next(array.Length);
            int temp = array[i];
            array[i] = array[randomIndex];
            array[randomIndex] = temp;
        }
    }

    // Método para apresentação de cada passo
    static void PrintArray(int[] array)
    {
        Console.WriteLine("Tentativa de embaralhamento: " + string.Join(", ", array));

        // Pausa para visualização
        System.Threading.Thread.Sleep(500);
    }
}
