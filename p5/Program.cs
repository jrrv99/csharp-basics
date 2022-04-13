using _Custom;
using _Pasteleria;

class Program : Custom
{
  public static void Main()
  {
    mainAction();
  }

  public static void mainAction()
  {
    Pasteleria pasteleria = new Pasteleria();
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
          registrarPedido (pasteleria);
          break;
        case 2:
          pasteleria.printTortas(1);
          pause("Presione ENTER para continuar");
          break;
        case 3:
          estadisticas (pasteleria);
          break;
        case 4:
          cargarTortas (pasteleria);
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
    writeLine("**** Don Carlos' Bakery  **** \n");
    writeLine("\t 1.- Registrar Pedido");
    writeLine("\t 2.- Tortas disponibles");
    writeLine("\t 3.- Ventas diarias");
    writeLine("\t 4.- Cargar Tortas");
    writeLine("\t 0.- Salir");
    write("\n Ingrese una opcion: ");
  }

  public static void registrarPedido(Pasteleria pasteleria)
  {
    int
      tortaId,
      cantidad;
    pasteleria.printTortas(1);

    write("Introduzca el numero de la torta que desea vender: ");
    tortaId = int.Parse(Console.ReadLine());

    clear();

    writeLine($"Torta {tortaId}:");
    pasteleria.printTorta (tortaId);

    write("Cuantas porciones llevara?: ");
    cantidad = int.Parse(Console.ReadLine());

    if (cantidad > pasteleria.disponibles(tortaId))
    {
      clear();
      writeLine("No hay suficientes porciones para despachar su pedido");
      writeLine("Intente con una cantidad menor");
      pause("Presione ENTER para continuar");
      return;
    }

    pasteleria.venderTorta (tortaId, cantidad);

    clear();
    writeLine("Se ha generado la orden correctamente!");
    pause("Presione ENTER para continuar");
  }

  public static void estadisticas(Pasteleria pasteleria)
  {
    pasteleria.printEstadisticas();
    pause("Presione ENTER para continuar");
  }

  public static void cargarTortas(Pasteleria pasteleria)
  {
    int opt = -1;
    writeLine("******** Cargar tortas ********");
    writeLine("\t 0.- Salir");
    writeLine("\t 1.- Cargar torta nueva");
    writeLine("\t 2.- Gestionar torta existente");
    write("Ingrese una opcion: ");
    opt = int.Parse(Console.ReadLine());

    switch (opt)
    {
      case 0:
        pause("Presione ENTER para continuar");
        return;
      case 1:
        cargarNuevaTorta (pasteleria);
        break;
      case 2:
        agregarExistente (pasteleria);
        break;
      default:
        writeLine("Selecciono una opcion no disponible");
        pause("Presione ENTER para continuar");
        return;
    }
  }

  public static void cargarNuevaTorta(Pasteleria pasteleria)
  {
    string
      sabor,
      decoracion;
    int porciones;

    clear();
    writeLine("******* Cargando Nueva Torta *******");
    write("Sabor: ");
    sabor = Console.ReadLine();
    write("Porciones: ");
    porciones = int.Parse(Console.ReadLine());
    write("Decoracion: ");
    decoracion = Console.ReadLine();

    pasteleria.createTorta (sabor, porciones, decoracion);

    clear();

    writeLine("Se ha creado una torta nueva");
    pause("Presione ENTER para regresar al menu principal");
  }

  public static void agregarExistente(Pasteleria pasteleria)
  {
    int
      tortaId,
      cantidad;
    clear();
    writeLine("******* Agregar porciones *******");
    pasteleria.printTortas(0);

    write("Ingrese el numero de la torta: ");
    tortaId = int.Parse(Console.ReadLine());

    clear();

    writeLine($"Torta {tortaId}:");
    pasteleria.printTorta (tortaId);

    write("Ingrese las porciones que desea agregar: ");
    cantidad = int.Parse(Console.ReadLine());

    pasteleria.agregarPorciones (tortaId, cantidad);

    writeLine($"\nSe han agregado {cantidad} porciones correctamente");

    pause("\nPresione ENTER para contunuar");
  }
}
