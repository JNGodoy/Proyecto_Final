// See https://aka.ms/new-console-template for more information

string Nombre = "Javier";
string Apellido = "Godoy";
string Dni = "35793289";
double Altura = 1.75;
int Edad = 31;

Console.WriteLine("Nombre: " + Nombre + "\n" + "Apellido: " + Apellido);
Console.WriteLine("Documento: " + Dni);
Console.WriteLine("Edad: " + Edad);
Console.WriteLine("Altura: " + Altura);

Console.WriteLine("Ingrese el primer número:");
string Numero1 = Console.ReadLine();
int parsedNumero1 = Convert.ToInt32(Numero1);
Console.WriteLine("Ingrese el segundo Número:");
string Numero2 = Console.ReadLine();
int parsedNumero2 = Convert.ToInt32(Numero2);

Console.WriteLine("Primer Numero: " + Numero1);
Console.WriteLine("Segundo Numero: " + Numero2);

int suma = parsedNumero1 + parsedNumero2;
Console.WriteLine("La suma de los números es: " + suma);



