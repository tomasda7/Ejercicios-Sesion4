// Ejercicio 3 - For
//Escribe un programa que realice estos pasos:
//Reciba 3 datos:
//ancho
//alto
//relleno o no
//Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y
//use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.
//En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

void DrawRectangle(int ancho, int alto, bool relleno) {

    if(relleno == true) {
        //anchura
        for (int i = 0; i < ancho; i++)
        {
            Console.Write("* ");

        }

        Console.WriteLine("");
    
        //altura
        for (int j = 0; j < alto; j++)
        {
            Console.WriteLine(" ****************** ");
        }

        //anchura
        for (int i = 0; i < ancho; i++)
        {
            Console.Write("* ");

        }
        
    } else
    {
        //anchura
        for (int i = 0; i < ancho; i++)
        {
            Console.Write("* ");

        }

        //altura
        for (int j = 0; j < alto; j++)
        {
	          Console.WriteLine(" ");
        }

        //anchura
        for (int i = 0; i < ancho; i++)
        {
            Console.Write("* ");

        }
        
    }

}

DrawRectangle(10,5,true);



