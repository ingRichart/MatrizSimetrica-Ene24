internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Tamaño de la Matriz (filas y columnas): ");
        int tam = Convert.ToInt32(Console.ReadLine());

        int[,] matrizSimetrica = new int[tam,tam];

        for (int i = 0; i < matrizSimetrica.GetLength(0); i++)
        {
            for (int j = 0; j < matrizSimetrica.GetLength(1); j++)
            {
                Console.Write($"Escribe la fila  {i + 1} y la colum  {j + 1} ");
                matrizSimetrica[i , j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        bool esSimetrica = false;
        for (var i = 0; i < matrizSimetrica.GetLength(0); i++)
        {
            // Console.WriteLine($"matrizSimetrica[1, i] {matrizSimetrica[1, i]} ");
            // Console.WriteLine($"matrizSimetrica[i, 1] {matrizSimetrica[i, 1]} ");
            // Console.WriteLine($"matrizSimetrica[tam-1, i] {matrizSimetrica[tam-1, i]}");
            // Console.WriteLine($"matrizSimetrica[i, tam-1] {matrizSimetrica[i, tam-1]} ");
            if (matrizSimetrica[1, i] == matrizSimetrica[i, 1] 
            && matrizSimetrica[tam-1, i] == matrizSimetrica[i, tam-1]) 
            {
                esSimetrica = true;
            }

            if (esSimetrica == false) {
                break;
            }
        }

        PrintArray(matrizSimetrica);
        if (esSimetrica) 
        {
            Console.WriteLine($"La matriz es Simetrica");
        }
        else 
        {
            Console.WriteLine($"La matriz no es Simetrica");
        }

    }
    static void PrintArray(int[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write($"{inputArray[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}