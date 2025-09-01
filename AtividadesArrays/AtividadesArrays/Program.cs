////1. **Remover Duplicatas**
////-Receba 10 números em um array e exiba-os sem valores duplicados.


//int[] numeros = new int[10];

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.WriteLine("Digite o numero");
//    numeros[i]= Convert.ToInt32(Console.ReadLine());
//}

//for(int i = 0;i < numeros.Length;i++)
//{
//    //1
//    int numero = numeros[i];
//    int repetido = 0;

//    //10
//    for(int j = 0; j < numeros.Length; j++)
//    {    //1 ==1
//        if(numero == numeros[j])
//        {
//            repetido++;
//            if(repetido == 2)
//            {
//                numeros[j] = 0;
//            }
//        }
//    }

//    numeros =  numeros.Distinct().ToArray();

//    for (int i = 0; i < numeros.Length; i++)
//    {
//        Console.WriteLine($"Numero {i + 1}: {numeros[i]}");
//    }

//}

//1. **Remover Duplicatas**
//-Receba 10 números em um array e exiba-os sem valores duplicados.


//int[] numeros = new int[10];

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.WriteLine("Digite o numero");
//    numeros[i] = Convert.ToInt32(Console.ReadLine());
//}

//for (int i = 0; i < numeros.Length; i++)
//{
//    //1
//    int numero = numeros[i];
//    int repetido = 0;

//    //10
//    for (int j = 0; j < numeros.Length; j++)
//    {    //1 ==1
//        if (numero == numeros[j])
//        {
//            repetido++;
//            if (repetido == 2)
//            {
//                numeros[j] = 0;
//            }
//        }
//    }

//    numeros = numeros.Distinct().ToArray();

//    for (int i = 0; i < numeros.Length; i++)
//    {
//        Console.WriteLine($"Numero {i + 1}: {numeros[i]}");
//    }

//}

//Peça 10 números ao usuário e exiba-os em ordem crescente.

int[] numeros = new int[10];

void Mostrar_Array(int[] numeros)
{

    numeros = numeros.Distinct().ToArray();

    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine($"Numero {i + 1}: {numeros[i]}");
    }

    Array.Sort(numeros);

}