// // 1. CONVERCIÓN DE TIPOS 

// Convertir un número entero a decimal
int numeroEntero;
Console.Write("Ingrese un numero entero: ");
numeroEntero = Convert.ToInt32(Console.ReadLine());
decimal numeroDecimal = Convert.ToDecimal(numeroEntero);
Console.WriteLine($"El número entero: {numeroEntero}, es igual en decimal a: {numeroDecimal}");

//Convertir un número decimal a flotante
decimal numdecimal;
Console.Write("\nIngrese un numero decimal: ");
numdecimal = Convert.ToDecimal(Console.ReadLine());
float numflotante = Convert.ToSingle(numdecimal);
Console.WriteLine($"El número decimal: {numdecimal}, convertido a flotante es: {numflotante}");

//Convertir un número flotante a entero
float numflotante2;
Console.Write("\nIngrese un numero flotante: ");
numflotante2 = Convert.ToSingle(Console.ReadLine());
int numEntero2 = Convert.ToInt32(numflotante2);
Console.WriteLine($"El número flotante: {numflotante2}, convertido a entero es: {numEntero2}");

//Convertir un caracter a entero
char caracter;
Console.Write("\nIngrese un caracter: ");
caracter = Convert.ToChar(Console.ReadLine());
int entero = Convert.ToInt32(caracter);
Console.WriteLine($"Caracter a entero (por medio de código ASCII): {entero}");

//Convertir un entero a caracter
int entero3;
Console.Write("\nIngrese un número entero: ");
entero3 = Convert.ToInt32(Console.ReadLine());
char caracter2 = Convert.ToChar(entero3);
Console.WriteLine($"El número: {entero3}, convertido a caracter (Código ASCII) es igual a: {caracter2}");

Console.ReadKey(); // Espera a que el usuario presione una tecla
Console.Clear(); // Limpia la pantalla


//2.OPERACIONES CON TIPOS DE DATOS 

//Calcular la suma de dos numeros enteros
int num1;
int num2;
Console.WriteLine("\t.:Calcular la suma de dos numeros enteros:. ");
Console.Write("Ingrese el primer numero: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingre el segundo numero: ");
num2 = Convert.ToInt32(Console.ReadLine());
int suma = num1 + num2;
Console.WriteLine("La suma es: " + suma);

//Calcular la resta de dos numeros decimales
decimal deci1;
decimal deci2;
Console.WriteLine("\n\t.:Calcular la resta de dos numero decimales:. ");
Console.Write("Ingrese el primer número: ");
deci1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
deci2 = Convert.ToDecimal(Console.ReadLine());
decimal resta = deci1 - deci2;
Console.WriteLine("La resta es: " + resta);

//Calcular la multiplicación de dos numeros flotantes
float float1;
float float2;
Console.WriteLine("\n\t.:Calcular la multiplicación de dos número flotantes:. ");
Console.Write("Ingrese el primer número: ");
float1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
float2 = Convert.ToSingle(Console.ReadLine());
float multi = float1 * float2;
Console.WriteLine("La multiplicación es: " + multi);

//Calcular la divisón de dos números enteros y su modulo
int entero1;
int entero2;
Console.WriteLine("\n\t.:Calcular la divisón de dos número enteros y su modulo:. ");
Console.Write("Ingrese el primer número: ");
entero1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
entero2 = Convert.ToInt32(Console.ReadLine());
int divi = entero1 / entero2;
int modulo = entero1 % entero2;
Console.WriteLine("La división es: " + divi);
Console.WriteLine("El modulo de la divisón es: " + modulo);

Console.ReadKey(); // Espera a que el usuario presione una tecla
Console.Clear(); // Limpia la pantalla


//3. USO DE CHAR Y STRING 


//Imprimir una cadena de texto en Mayusculas
Console.WriteLine("\n\t.:Convertir cadena de texto a Mayusculas:.");
Console.WriteLine("Ingrese una cadena de texto: ");
string cadena = Console.ReadLine();
Console.WriteLine("La cadena en Mayusculas es: " + cadena.ToUpper());


//Imprimir una cadena de texto en minusculas
Console.WriteLine("\n\t.:Convertir cadena de texto a minusculas:.");
Console.Write("Ingrese una cadena de texto: ");
string cadena2 = Console.ReadLine();
Console.WriteLine("La cadena en minusculas es: " + cadena2.ToLower());


//Imprimir una cadena de texto al revés 
Console.WriteLine("\n\t.:Convertir cadena de texto al revés:.");
// Leer la cadena de texto
Console.Write("Ingrese una cadena de texto: ");
string cadenaN = Console.ReadLine();
// Colocar la cadena al revés e imprimirla
char[] cadenaR = cadenaN.ToCharArray();
Array.Reverse(cadenaR);
string reversedString = new string(cadenaR);
Console.WriteLine("La cadena al revés es: " + reversedString);


// Buscar una palabra en una cadena de texto
Console.WriteLine("\n\t.:Buscar una palabra en una cadena de texto:.");
Console.Write("Ingrese una cadena de texto: ");
string cadena4 = Console.ReadLine();

// Leer la palabra a buscar
Console.Write("Ingrese la palabra a buscar: ");
string palabra = Console.ReadLine();

// Buscar la palabra en la cadena
//método Contains() para buscar la palabra en la cadena
bool found = palabra.Contains(palabra);

// Imprimir el resultado
if (found)
{
    Console.WriteLine("La palabra " + palabra + " se encuentra en la cadena.");
}
else
{
    Console.WriteLine("La palabra " + palabra + " no se encuentra en la cadena.");
}


//Contar el número de vocales de una cadena de texto
Console.WriteLine("\n\t.:Contar el número de vocales de una cadena de texto:.");
Console.Write("Ingrese una cadena de texto: ");
string cadena5 = Console.ReadLine();

// Contar el número de vocales
int contador = 0;
foreach (char c in cadena5)//bucle foreach para recorrer cada carácter de la cadena y verificar si es una vocal
{
    if ("AEIOUaeiou".IndexOf(c) != -1)//método IndexOf() para buscar cada carácter en la cadena "AEIOUaeiou"
    {
        contador++;
    }
}
// Imprimir el resultado
Console.WriteLine("La cadena contiene " + contador + " vocales.");

Console.ReadKey(); // Espera a que el usuario presione una tecla
Console.Clear(); // Limpia la pantalla

//4. USO DE TIPOS DE DATOS NUMERICOS

//Calcular el área de un triangulo
double bsTriangulo, alTriangulo;//Los números double permiten una precisión de alrededor de 15-16 cifras
Console.WriteLine("\n\t.:Calcular el área de un triangulo:.");
Console.Write("Ingrese la base del triangulo: ");
bsTriangulo = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la altura del triangulo: ");
alTriangulo = Convert.ToDouble(Console.ReadLine());

double areaTriangulo = (bsTriangulo * alTriangulo) / 2;
Console.WriteLine("El area del triangulo es: " + areaTriangulo);

//Calcular el volumen de una esfera
// Leer el radio de la esfera
Console.WriteLine("\n\t.:Calcular el volumen de una esfera:.");
Console.Write("Ingrese el radio de la esfera: ");
double radio = Convert.ToDouble(Console.ReadLine());

// Calcular el volumen de la esfera
//Fórmula del volumen de la esfera (4/3 * pi * radio^3) utilizando la constante Math.PI para el valor de pi
//y el método Math.Pow() para elevar el radio al cubo
double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);

// Imprimir el resultado
Console.WriteLine("El volumen de la esfera es: " + volumen);


//Calcular la distancia entre dos puntos
double x1, x2, y1, y2;

Console.WriteLine("\n\t.:Calcular la distancia entre dos puntos:.");
Console.WriteLine("\t.:utilizando la fórmula de distancia euclidiana:.");
Console.Write("Ingrese las coordenadas del primer punto (x1, y1): ");
x1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese el valor de y1: ");
y1 = double.Parse(Console.ReadLine());

Console.Write("Ingrese las coordenadas del segundo punto (x2, y2): ");
x2 = double.Parse(Console.ReadLine());
Console.Write("Ingrese el valor de y2: ");
y2 = double.Parse(Console.ReadLine());

//Math.Sqrt = devuelve la raíz cuadrada de un número
double distancia = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

Console.WriteLine("La distancia entre los puntos es: " + distancia);


//Convertir una temperatura en grados Celsius a grados Fahrenheit
Console.WriteLine("\n\t.:Convertir temperatura en grados Celsius a grados Fahrenheit:.");
double celsius, fahrenheit;
Console.Write("Ingrese la temperatura en grados Celsius: ");
celsius = Convert.ToDouble(Console.ReadLine());

fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine("La temperatura en grados Fahrenheit es: " + fahrenheit);


//Convertir una temperatura en grados Fahrenheit a grados Celsius
Console.WriteLine("\n\t.:Convertir temperatura en grados Fahrenheit a grados Celsius:.");
double celsius2, fahrenheit2;
Console.Write("Ingrese la temperatura en grados Fahrenheit: ");
fahrenheit2 = Convert.ToDouble(Console.ReadLine());

celsius2 = (fahrenheit2 - 32) * 5 / 9;
Console.WriteLine("La temperatura en grados Celsius es: " + celsius2);
