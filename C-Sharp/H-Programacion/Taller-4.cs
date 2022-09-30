// Crear un menú y resolver cada uno de los puntos indicados en el taller
Console.Clear();
start();
void mostrar_menu()
{
    Console.WriteLine("*------------------------------------------------------------*");
    Console.WriteLine("|                     OPCIONES DE MENÚ                       |");
    Console.WriteLine("|------------------------------------------------------------|");
    Console.WriteLine("|                       1. Punto 6                           |");
    Console.WriteLine("|                       2. Punto 8                           |");
    Console.WriteLine("|                       3. Punto 11                          |");
    Console.WriteLine("|                       4. Punto 13                          |");
    Console.WriteLine("|                       5. Salir del menú                    |");
    Console.WriteLine("*------------------------------------------------------------*");
    Console.Write(" Ingrese una opción: ");
}
void start()
{
    mostrar_menu();
    string? value = Console.ReadLine();
    int number;
    if (checkN(value))
    {
        number = Convert.ToInt32(value);
        switch (number)
        {
            case 1:
                Console.Clear();
                Punto6();
                Console.WriteLine("Presione enter para continuar");
                Console.ReadLine();
                start();
                break;
            case 2:
                Console.Clear();
                Punto8();
                Console.WriteLine("Presione enter para continuar");
                Console.ReadLine();
                start();
                break;
            case 3:
                Console.Clear();
                Punto11();
                Console.WriteLine("Presione enter para continuar");
                Console.ReadLine();
                start();
                break;
            case 4:
                Console.Clear();
                Punto13();
                Console.WriteLine("Presione enter para continuar");
                Console.ReadLine();
                start();
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("¡Feliz día!");
                break;
            default:
                Console.WriteLine("Número fuera de los limites");
                start();
                break;
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Número fuera de los limites");
        start();
    }

}



/*
Punto 6 
De los 50 elementos de un vector, muestre cuántos son: pares, impares, negativos y positivos
*/
void Punto6()
{
    int i = 0;
    int[] vector = new int[50];
    int nPares = 0;
    int nImpares = 0;
    int nNegativos = 0;
    int nPositivos = 0;

    while (i < 50)
    {
        string? temN;
        Console.WriteLine($"Escribe el número en la posición {i + 1}");
        temN = Console.ReadLine();
        if (checkINT(temN))
        {
            vector[i] = Convert.ToInt32(temN);
            addValues(vector[i]);
            i++;
        }
    }
    Console.WriteLine($"La cantidad \n De números positivos es de {nPositivos} \n De número negativos es de {nNegativos} \n De números pares es de {nPares} \n De números impares es de {nImpares}");

    void addValues(int n)
    {
        if (n != 0)
        {
            if ((n % 2) == 0)
            {
                nPares++;
            }
            else
            {
                nImpares++;
            }
            if (n > 0)
            {
                nPositivos++;
            }
            else
            {
                nNegativos++;
            }
        }
    }
}


/*
Punto 8 
Se  tiene  un  vector  con las  notas  de  un  grupo  de  30 estudiantes. Hallar y mostrar la nota más alta y la más baja, cuántas personas perdieron  y la nota promedio del grupo
*/
void Punto8()
{
    int success = 0;
    double[] notes = new double[30];
    double menor = 100;
    double mayor = 0;
    double sumaT = 0;
    int i = 0;
    string? temN;

    while (i < 30)
    {
        Console.WriteLine($"Escribe la nota del estudiante {i + 1}");
        temN = Console.ReadLine();
        if (checkN(temN))
        {
            notes[i] = Convert.ToDouble(temN);
            if (notes[i] < menor)
            {
                menor = notes[i];
            }
            if (notes[i] > mayor)
            {
                mayor = notes[i];
            }
            if (notes[i] >= 3.0)
            {
                success = success + 1;
            }

            sumaT = sumaT + notes[i];
            i++;
        }
    }

    Console.WriteLine($"La nota más baja del grupo es de {menor}");
    Console.WriteLine($"La nota más alta del grupo es de {mayor}");
    Console.WriteLine($"La cantidad de personas que perdieron es de {30 - success}");
    Console.WriteLine($"La nota promedio del grupo es de {sumaT / 30}");
}

/*
Punto 11 
Lea un vector S de N elementos e inviértalo. Utilice otro Vector. 
*/
void Punto11()
{
    string? temN;
    double[] S;
    double[] SI;
    int i = 0;
    int n;
    Console.WriteLine("¿Cuantos números desea ingresar?");
    temN = Console.ReadLine();
    if (checkINT(temN))
    {
        n = Convert.ToInt32(temN);
        S = new double[n];
        while (i < n)
        {
            Console.WriteLine($"Escribe el número que estará en la posición {i + 1}");
            temN = Console.ReadLine();
            if (checkN(temN))
            {
                S[i] = Convert.ToInt32(temN);
                i++;
            }
        }
        SI = reverse(S);
        Console.WriteLine("El orden original de los números ingresados es ");
        Console.WriteLine(String.Join(" - ", S));
        Console.WriteLine("El orden invertido de los números ingresados es");
        Console.WriteLine(String.Join(" - ", SI));
    }
    else
    {
        Punto11();
    }
    double[] reverse(double[] vector)
    {
        int i = 0;
        int j = vector.Length - 1;
        double[] nVector = new double[vector.Length];
        while (i < vector.Length)
        {
            nVector[i] = vector[j];
            i++;
            j--;
        }
        return nVector;
    }

}



/*
Punto 13
Elabore un algoritmo que lea un vector de N elementos. Si el número de elementos es par 
intercambiar el elemento i‐ésimo por el elemento i‐ésimo+1. Mostrar el vector final. Si el 
número de elementos es impar, indicarlo en un mensaje que no es posible hacer el intercambio
y forzar al usuario hasta que digite un número de elementos par
*/

// Pedirle al usuario el número de digitos que quiere agregar
void Punto13()
{
    int numberElement;
    Console.WriteLine("Dime el número de elementos que quieres agregar");
    numberElement = Convert.ToInt32(Console.ReadLine());
    if ((numberElement % 2) == 0)
    {
        double[] numbers = new double[numberElement];
        Console.WriteLine("El resultado final quedaría " + String.Join(" - ", reverse(fullArray(numbers))));

    }
    else
    {
        Console.WriteLine("El número de elementos dados debe de ser par");
        Punto13();
    }
    // Hacer que el usuario ingrese los elementos que estarán dentro del arreglo
    double[] fullArray(double[] array)
    {
        double tempN;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Dime el elemento número {i + 1} que quieres agregar");
            tempN = Convert.ToInt32(Console.ReadLine());
            array[i] = tempN;
        }
        return array;
    }
    // Intercambiar las posiciones de las parejas del arreglos
    double[] reverse(double[] array)
    {
        double temp;
        for (int i = 0; i < array.Length; i = i + 2)
        {
            temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
        }
        return array;
    }
}


// Comprueba que el número ingresado sea entero
bool checkINT(string? n)
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

// Comprueba que el valor ingresado sea un número
bool checkN(string? n)
{
    bool answer = true;
    double temN = 0;
    if (double.TryParse(n, out temN))
    {
        answer = true;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("El valor a ingresar debe de ser un número");
        answer = false;
    }
    return answer;
}
