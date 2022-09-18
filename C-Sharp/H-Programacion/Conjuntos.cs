/*
Realizar un programa que pida al usuario 5 números 2 veces
Cada uno de los números almacenarlos en un arreglo individual
Crear un tercer arreglo que contenga solo los números que no están repetidos
    + Los números pueden estar repetidos ni en su propio vector, ni en el otro vector
Mostrarle al usuario cuales son los números que no están repetidos 
*/

start();

void start()
{
    int[] vector = new int[5];
    int[] vector2 = new int[5];
    Console.WriteLine("Comienza escribiendo los 5 números del primer conjunto");
    vector = askN(vector, 5);
    Console.WriteLine("Ahora escribe los 5 números del segundo conjunto");
    vector2 = askN(vector2, 5);
    showAnswers(vector, vector2);
}

// Pregunta al usuario un conjunto de números
int[] askN(int[] vector, int length)
{
    int i = 0;
    int[] newVector = new int[length];
    while (i < length)
    {
        Console.WriteLine($"Escribe el número {i + 1}");
        string? temN;
        temN = Console.ReadLine();
        if (check(temN))
        {
            int number = Convert.ToInt32(temN);
            newVector[i] = number;
            i++;
        }
    }
    return newVector;
}

void showAnswers(int[] vector, int[] vector2)
{
    int[] tempV = new int[10];

    tempV = union(vector, vector2);
    int[] vector3 = new int[knowL(tempV)];
    vector3 = comparator(tempV, vector3.Length);

    Console.WriteLine("De los 2 conjuntos de números ingresados, los números no repetidos son");
    Console.WriteLine(String.Join("-", vector3));

    // Devuelve el número de elementos no repetidos en un vector
    int knowL(int[] v)
    {
        bool answer = true;
        int i = 0;
        int j;
        int contador = 0;
        while (i < v.Length)
        {
            j = 0;
            answer = true;
            while (j < v.Length)
            {
                if (i == j)
                {
                    j++;
                }
                else if (v[i] == v[j] && v[i] != 0)
                {
                    answer = false;
                }
                j++;
            }
            if (answer == true)
            {
                contador++;
            }
            i++;
        }
        return contador;
    }

    // Compara los elementos de un vector y solo devuelve los no repetidos
    int[] comparator(int[] v, int length)
    {
        bool answer = true;
        int[] final = new int[length];
        int itter = 0;
        int i = 0;
        int j;
        while (i < v.Length)
        {
            j = 0;
            answer = true;
            while (j < v.Length)
            {
                if (i == j)
                {
                    j++;
                }
                else if (v[i] == v[j])
                {
                    answer = false;
                }
                j++;
            }
            if (answer == true)
            {
                final[itter] = v[i];
                itter++;
            }
            i++;
        }
        return final;
    }

    // Une 2 vectores en uno solo
    int[] union(int[] v1, int[] v2)
    {
        int[] union = new int[v1.Length + v2.Length];
        int i = 0;
        int tempI = 0;
        while (tempI < v1.Length)
        {
            union[i] = v1[tempI];
            tempI++;
            i++;
        }
        tempI = 0;
        while (tempI < v2.Length)
        {
            union[i] = v2[tempI];
            tempI++;
            i++;
        }
        return union;
    }
}

// Comprueba que el número ingresado sea entero
bool check(string? n)
{
    bool answer = true;
    int temN = 0;
    if (int.TryParse(n, out temN))
    {
        answer = true;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("El número a ingresar debe de ser un entero");
        answer = false;
    }
    return answer;
}
