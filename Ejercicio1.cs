//Ejercicio 1 - While
//Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola.
//Es decir, un programa que presente para el 1:

Console.WriteLine("Ingrese un numero entero: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;

Console.WriteLine($"Tabla de mulplicar del {num}: ");
while(i <= 10) {
    Console.WriteLine($"{num} * {i} = " + num * i);
    i++;
}
