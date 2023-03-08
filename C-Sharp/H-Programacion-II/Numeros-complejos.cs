/* 
Crea una clase Complejo con métodos para sumar, restar, multiplicar y dividir números complejos.
Escribe una clase Complejo que modele el comportamiento de los números complejos. 
Un número complejo, es una entidad matemática que viene dada por un par de números reales, el primero a se denomina la parte real y al segundo b la parte imaginaria. 
Se representa escribiendo las dos partes del número entre paréntesis (a, b) o también de la forma a + bi.
La i se denomina unidad imaginaria, representa la raíz cuadrada de -1. 
La clase Complejo tendrá dos datos privados de tipo double: parte real y parte imaginaria.
*/

// Creación de las variables tipo "Complejo"
Complejo numeroPrimero = new Complejo();
Complejo numeroSegundo = new Complejo();
double numeroDoble = 0;

double[] numeroTemporal = new double[2];

Console.WriteLine("Calculadora de números complejos");
// Obtención de valores para el primer número
Console.WriteLine("Ingresa el primer número complejo");
numeroPrimero = ObtenerNumeroComplejo();

// Obtención de valores para el segundo número
Console.WriteLine("Ingresa el segundo número complejo");
numeroSegundo = ObtenerNumeroComplejo();

// Obtención de valor double
Console.WriteLine("Ingresa un valor 'Double'");
numeroDoble = Convert.ToDouble(Console.ReadLine());

// Función para obtener un número complejo
Complejo ObtenerNumeroComplejo()
{
    double[] numeroTemporal = new double[2];
    Console.WriteLine("Ingresa la parte real del número");
    numeroTemporal[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingresa la parte imaginaria del número");
    numeroTemporal[1] = Convert.ToDouble(Console.ReadLine());

    Complejo numero = new Complejo();
    numero.ParteReal = numeroTemporal[0];
    numero.ParteImaginaria = numeroTemporal[1];

    return numero;
}

// Realizamos operaciones con números complejos y las mostramos por consola
Console.WriteLine("Operaciones con números complejos:");

// Mostramos la suma de los números complejos
Console.WriteLine("Suma:");
Resultados(numeroPrimero.Suma(numeroPrimero, numeroSegundo));

// Mostramos la resta de los números complejos
Console.WriteLine("Resta:");
Resultados(numeroPrimero.Resta(numeroPrimero, numeroSegundo));

// Mostramos la multiplicación de los números complejos
Console.WriteLine("Multiplicación:");
Resultados(numeroPrimero.Multiplicacion(numeroPrimero, numeroSegundo));

// Mostramos la multiplicación del primer número complejo por el número double
Console.WriteLine($"Multiplicación del primer número por {numeroDoble}:");
Resultados(numeroPrimero.MultiplicacionPorDouble(numeroPrimero, numeroDoble));

// Mostramos la multiplicación del segundo número complejo por el número double
Console.WriteLine($"Multiplicación del segundo número por {numeroDoble}:");
Resultados(numeroSegundo.MultiplicacionPorDouble(numeroSegundo, numeroDoble));

// Mostramos la división de los números complejos
Console.WriteLine("División:");
Resultados(numeroPrimero.Division(numeroPrimero, numeroSegundo));

// Función que muestra el resultado por consola
static void Resultados(Complejo numeroComplejo)
{
    Console.WriteLine($"{numeroComplejo.ParteReal}, {numeroComplejo.ParteImaginaria}i");
}


// Creación de la clase "Complejo"
public class Complejo
{
    // Atributos
    private double parteReal;
    private double parteImaginaria;

    /* CONSTRUCTORES */
    // Constructor por defecto
    public Complejo()
    {
        parteReal = 0;
        parteImaginaria = 0;
    }

    // Constructor con argumentos
    public Complejo(double parteReal, double parteImaginaria)
    {
        this.parteReal = parteReal;
        this.parteImaginaria = parteImaginaria;
    }

    // Propiedades
    public double ParteReal
    {
        get { return parteReal; }
        set { parteReal = value; }
    }

    public double ParteImaginaria
    {
        get { return parteImaginaria; }
        set { parteImaginaria = value; }
    }

    // Métodos
    // Método de suma
    public Complejo Suma(Complejo primerComplejo, Complejo segundoComplejo)
    {
        Complejo resultado = new Complejo();
        resultado.ParteReal = primerComplejo.ParteReal + segundoComplejo.ParteReal;
        resultado.ParteImaginaria = primerComplejo.ParteImaginaria + segundoComplejo.ParteImaginaria;
        return resultado;
    }
    // Método de resta
    public Complejo Resta(Complejo primerComplejo, Complejo segundoComplejo)
    {
        Complejo resultado = new Complejo();
        resultado.ParteReal = primerComplejo.ParteReal - segundoComplejo.ParteReal;
        resultado.ParteImaginaria = primerComplejo.ParteImaginaria - segundoComplejo.ParteImaginaria;
        return resultado;
    }
    // Método de multiplicación
    public Complejo Multiplicacion(Complejo primerComplejo, Complejo segundoComplejo)
    {
        Complejo resultado = new Complejo();
        resultado.ParteReal = primerComplejo.ParteReal * segundoComplejo.ParteReal - primerComplejo.ParteImaginaria * segundoComplejo.ParteImaginaria;
        resultado.ParteImaginaria = primerComplejo.ParteReal * segundoComplejo.ParteImaginaria + primerComplejo.ParteImaginaria * segundoComplejo.ParteReal;
        return resultado;
    }
    // Método de multiplicación por un double
    public Complejo MultiplicacionPorDouble(Complejo primerComplejo, double numero)
    {
        Complejo resultado = new Complejo();
        resultado.ParteReal = primerComplejo.ParteReal * numero;
        resultado.ParteImaginaria = primerComplejo.ParteImaginaria * numero;
        return resultado;
    }
    // Método de división
    public Complejo Division(Complejo primerComplejo, Complejo segundoComplejo)
    {
        Complejo resultado = new Complejo();
        double denominador = Math.Pow(segundoComplejo.ParteReal, 2) + Math.Pow(segundoComplejo.ParteImaginaria, 2);
        resultado.ParteReal = (primerComplejo.ParteReal * segundoComplejo.ParteReal + primerComplejo.ParteImaginaria * segundoComplejo.ParteImaginaria) / denominador;
        resultado.ParteImaginaria = (primerComplejo.ParteImaginaria * segundoComplejo.ParteReal - primerComplejo.ParteReal * segundoComplejo.ParteImaginaria) / denominador;
        return resultado;
    }
}
