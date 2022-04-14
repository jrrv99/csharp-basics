using _Custom;
using Talleres;

class Program : Custom
{
  public static void Main()
  {
    mainAction();
  }

  public static void mainAction()
  {
    Taller taller = new Taller();
    int opt = -1;

    do
    {
      menu();
      opt = int.Parse(Console.ReadLine());
      clear();

      switch (opt)
      {
        case 0: //Salir
          pause("¡Hasta Luego! \n¡Presione Enter para Salir!");
          break;
        case 1:
          registrarMoto (taller);
          break;
        case 2:
          retirarMoto (taller);
          break;
        case 3:
          printMotos (taller);
          break;
        default:
          pause("¡Ingrese una opcion validad! \n¡Presione Enter!");
          break;
      }
    }
    while (opt != 0);
  }

  public static void menu()
  {
    clear();
    writeLine("**** Taller de motos El Maquinista  **** \n");
    writeLine("\t 1.- Registrar nueva moto");
    writeLine("\t 2.- Retirar moto");
    writeLine("\t 3.- Lista de Motos");
    writeLine("\t 0.- Salir");
    write("\n Ingrese una opcion: ");
  }

  public static void registrarMoto(Taller taller)
  {
    string
      clientName,
      registroDeIngreso,
      observacionesDelCliente;

    writeLine("********* Registro de Moto *********\n");
    write("Nombre del Propietario: ");
    clientName = Console.ReadLine();
    write("Registro de Ingreso: ");
    registroDeIngreso = Console.ReadLine();
    write("Observaciones del cliente: ");
    observacionesDelCliente = Console.ReadLine();

    taller.registrarMoto (
      clientName,
      registroDeIngreso,
      observacionesDelCliente
    );

    clear();

    writeLine("Se ha registrado la moto correctamente");

    pause("\nPresione ENTER para volver al menu");
  }

  public static void retirarMoto(Taller taller)
  {
    int motoId;
    string registroDeSalida, arreglos;

    taller.printMotos();

    if (!taller.theresMotos())
    {
      pause("\nPresione ENTER para volver al menu");
      return;
    }

    write("Ingrese el numero de la moto: ");
    motoId = int.Parse(Console.ReadLine());

    clear();

    writeLine("********* Entrega de Moto *********\n");
    write("\tRegistro de entrega: ");
    registroDeSalida = Console.ReadLine();
    write("\tArreglos: ");
    arreglos = Console.ReadLine();

    taller.entregarMoto(motoId, registroDeSalida, arreglos);

    writeLine("\nSe ha entregado correctamente");

    pause("\nPresione ENTER para volver al menu");
  }

  public static void printMotos(Taller taller)
  {
    taller.printMotos();

    pause("\nPresione ENTER para volver al menu");
  }
}
