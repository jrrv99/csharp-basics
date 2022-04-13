using System;
using _Custom;
using Figures;

class Program : Custom
{
    public static void Main(string[] args)
    {
        mainAction();
    }

    public static void mainAction()
    {
        int opt = -1;

        do
        {
            mainMenu();
            opt = Convert.ToInt16(Console.ReadLine());

            switch (opt)
            {
                case 0: //Salir
                    clear();
                    pause("¡Hasta Luego! \n¡Presione Enter para Salir!");
                    break;
                case 1:
                    rectangulo();
                    break;
                case 2:
                    triangulo();
                    break;
                case 3:
                    trapecio();
                    break;
                default:
                    pause("¡Ingrese una opcion validad! \n¡Presione Enter!");
                    break;
            }
        }
        while (opt != 0);
    }

    public static void mainMenu()
    {
        clear();
        writeLine("**** Area de figuras geometricas **** \n");
        writeLine("\t 1.- Rectangulo");
        writeLine("\t 2.- Triangulo");
        writeLine("\t 3.- Trapecio");
        writeLine("\t 0.- Salir");
        write("\n Que area desea calcular?: ");
    }

    public static void rectangulo()
    {
        double
            b,
            altura;

        write("Introduzca la base: ");
        b = Convert.ToDouble(Console.ReadLine());
        write("Introduzca la altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        Rectangulo f = new Rectangulo(b, altura);
        writeLine($"Areal del Rectangulo: {f.getArea()}");

        pause("\n¡Presione Enter para volver al menu!");
    }

    public static void triangulo()
    {
        double
            b,
            altura;

        write("Introduzca la base: ");
        b = Convert.ToDouble(Console.ReadLine());
        write("Introduzca la altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        Triangulo f = new Triangulo(b, altura);
        writeLine($"Areal del Triangulo: {f.getArea()}");

        pause("\n¡Presione Enter para volver al menu!");
    }

    public static void trapecio()
    {
        double
            b,
            b1,
            altura;

        write("Introduzca la base mayor: ");
        b = Convert.ToDouble(Console.ReadLine());
        write("Introduzca la base menor: ");
        b1 = Convert.ToDouble(Console.ReadLine());
        write("Introduzca la altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        Trapecio f = new Trapecio(b, b1, altura);
        writeLine($"\nAreal del Trapecio: {f.getArea()}");

        pause("\n¡Presione Enter para volver al menu!");
    }
}
