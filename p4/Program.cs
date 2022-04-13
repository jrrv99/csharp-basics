using _Custom;
using Personas;

class Program : Custom
{
    public static void Main(string[] args)
    {
        mainAction();
    }

    public static void mainAction()
    {
        List<Persona> personas = new List<Persona>();

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
                    ingresarPersonas(personas);
                    break;
                case 2:
                    estadisticas(personas);
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
        writeLine("**** Secretaria de Salud Municipal **** \n");
        writeLine("\t 1.- Ingresar personas");
        writeLine("\t 2.- Ver estadisticas");
        writeLine("\t 0.- Salir");
        write("\n Ingrese una opcion: ");
    }

    public static void ingresarPersonas (List<Persona> personas) {
        int opt = -1;
        (double peso, double estatura) data;

        do {
            clear();
            writeLine("Ingrese los datos de un encuestado\n");
            write("Peso (kg): ");
            data.peso = double.Parse(Console.ReadLine());
            write("Estatura (M2): ");
            data.estatura = double.Parse(Console.ReadLine());

            personas.Add(new Persona(data.peso, data.estatura));

            clear();
            writeLine($"Peso: {data.peso}kg | Estatura: {data.estatura}M2 \n");

            writeLine("\t 1 .- Ingresar otra persona");
            writeLine("\t 0 .- Volver al menu principal");
            write("\n Ingrese una opcion: ");
            opt = int.Parse(Console.ReadLine());
        } while (opt != 0);
    }

    public static void estadisticas(List<Persona> personas) {
        int index;

        clear();
        foreach (Persona p in personas) {
            index = personas.IndexOf(p);

            writeLine($"Encuestado {index+1}");
            writeLine($"\t Peso: {p.peso}");
            writeLine($"\t Estatura: {p.estatura}");
            writeLine($"\t IMC: {p.getImc():N2}");
            writeLine($"\t Rango: {p.getRange()}\n");

        }

        pause("\n¡Presione Enter para volver al menu!");
    }
}