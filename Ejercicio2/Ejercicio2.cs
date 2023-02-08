//Ejercicio 2 - Do while
//Escribe un programa que realice estos pasos:
//Reciba al menos un número por consola
//Determine si el número es positivo o negativo
//Presente un contador para cada tipo (positivo y negativo).

Console.WriteLine("Ingresa un numero positivo o negativo: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 0) {
    Console.WriteLine("Contador de numeros positivos: ");
    int i = 1;
    do { Console.WriteLine(i); i++; } while (i <= num);

} else if(num < 0) {
    Console.WriteLine("Contador de numeros negativos: ");
    int j = -1;
    do { Console.WriteLine(j); j--; } while (j >= num);

} else { Console.WriteLine("El numero 0 no es positivo ni negativo."); }