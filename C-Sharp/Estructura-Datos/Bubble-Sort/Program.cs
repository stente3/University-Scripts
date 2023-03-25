/*
  Pedirle al usuario la cantidad de numeros que habrá en el arreglo
  Acto seguido preguntarle los números que irán en el arreglo
  Por último devuelvele el arraglo entregado organizado
*/
double[] sortArray;
int amount = AskINT("Escribe la cantidad de elementos que quieres agregar");
double[] array = new double[amount];
array = AskNumbers(array);
sortArray = BubbleSort(array);

Console.WriteLine($"La lista anteriormente dada fue ordenada, este es el resultado");
for (int i = 0; i < sortArray.Length; i++)
{
  Console.WriteLine(sortArray[i]);
}

// Toma un arreglo de números desordenado y lo ordena 
double[] BubbleSort(double[] array)
{
  int i = 0;
  while (i < array.Length)
  {
    int j = 0;
    while (j < array.Length)
    {
      if (j != i)
      {
        if (array[i] < array[j])
        {
          double tempN = array[j];
          array[j] = array[i];
          array[i] = tempN;
        }
      }
      j++;
    }
    i++;
  }
  return array;
}

// Pregunta el número de datos indicado para rellenar un arreglo
double[] AskNumbers(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    double tempN = AskDouble($"Escribe el número {i + 1}");
    array[i] = tempN;
  }
  return array;
}
// Pregunta un número entero y no permite que el usuario agrege otra cosa
int AskINT(string message)
{
  Console.WriteLine(message);
  string? tempN = Console.ReadLine();
  int number;
  if (int.TryParse(tempN, out number))
  {
    number = Convert.ToInt32(tempN);
    return number;
  }
  Console.WriteLine("Valor invalido");
  return AskINT(message);
}
// Pregunta un número double y no permite que el usuario agrege otra cosa
double AskDouble(string message)
{
  Console.WriteLine(message);
  string? tempN = Console.ReadLine();
  double number;
  if (double.TryParse(tempN, out number))
  {
    number = Convert.ToDouble(tempN);
    return number;
  }
  Console.WriteLine("Valor invalido");
  return AskDouble(message);
}