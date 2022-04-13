using _Custom;
using Tiendas;

class Program : Custom
{
  public static void Main()
  {
    mainAction();
  }

  public static void menu()
  {
    clear();
    writeLine("\t**** Video tienda EL PORVENIR **** \n");
    writeLine("\t 1.- Agregar pelicula");
    writeLine("\t 2.- Registrar cliente");
    writeLine("\t 3.- Rentar Pelicula");
    writeLine("\t 4.- Devolver Pelicula");
    writeLine("\t 5.- Lista de Peliculas");
    writeLine("\t 0.- Salir");
    write("\n Introduzca una opción: ");
  }

  public static void mainAction()
  {
    Tienda tienda = new Tienda();
    int opt = -1;

    do
    {
      menu();
      opt = int.Parse(Console.ReadLine());

      switch (opt)
      {
        case 0: //Salir
          clear();
          pause("¡Hasta Luego! \n¡Presione Enter para Salir!");
          break;
        case 1:
          registrarPeli (tienda);
          break;
        case 2:
          registrarUser (tienda);
          break;
        case 3:
          rentarPeli (tienda);
          break;
        case 4:
          retornarPeli (tienda);
          break;
        case 5:
          tienda.printPelis();
          pause("\t|> Presione Enter para continuar!");
          break;
        default:
          pause("¡Ingrese una opcion validad! \n¡Presione Enter!");
          break;
      }
    }
    while (opt != 0);
  }

  public static void registrarPeli(Tienda tienda)
  {
    clear();
    writeLine("_Registrar pelicula_");
    write("Ingrese el nombre de la pelicua: ");
    string name = Console.ReadLine();

    tienda.createPeli (name);

    clear();
    writeLine($"Se ha agregado la pelicula {name}");
    pause("\nPresione ENTER para continuar");
  }

  public static void registrarUser(Tienda tienda)
  {
    clear();
    writeLine("_Registrar Usuario");
    write("Ingrese el nombre del Usuario: ");
    string name = Console.ReadLine();

    tienda.createUser (name);

    clear();
    writeLine($"Se ha agregado el usuario:  {name}");
    pause("\nPresione ENTER para continuar");
  }

  public static void rentarPeli(Tienda tienda)
  {
    int
      peliId,
      userId;

    clear();
    writeLine("****** Rentar Peliculas \n");
    tienda.printPelis();
    write("Introduzca el id de la pelicula: ");
    peliId = int.Parse(Console.ReadLine());

    if (!tienda.peliDisp(peliId))
    {
      writeLine("Pelicula no disponible");
      pause("\nPresione ENTER para continuar");
      return;
    }

    tienda.printUsers();
    writeLine("A cúal usuario se le rentara?");
    write("Introduzca el id del usuario: ");
    userId = int.Parse(Console.ReadLine());

    clear();

    if (tienda.alquilarPeli(userId, peliId))
    {
      writeLine("Se ha rentado correctamente");
    }
    else
    {
      writeLine("Ups... Something went wrong");
    }

    pause("\t|> Presione Enter para continuar!");
  }

  public static void retornarPeli(Tienda tienda)
  {
    int
      peliId,
      userId;

    clear();
    writeLine("****** Retornar Peliculas \n");
    tienda.listUsersInRent();

    writeLine("Qué usuario desea retornar peliculas?");
    write("Introduzca el id del usuario: ");
    userId = int.Parse(Console.ReadLine());

    clear();

    tienda.pelisPerUser (userId);
    writeLine("Qué pelicula desea retornar?");
    write("Introduzca el id de la pelicula: ");
    peliId = int.Parse(Console.ReadLine());

    clear();

    write("Alguna novedad sobre la pelicula? (s/sí, n/no): ");
    if (Console.ReadLine() == "s")
    {
      clear();
      write("Describa la novedad: ");
      tienda.addNovedad(peliId, Console.ReadLine());
      pause("\nPresione ENTER para continuar");
    }

    clear();

    if (tienda.retornarPeli(userId, peliId))
    {
      writeLine("Se ha retornado la pelicula correctamente");
    }
    else
    {
      writeLine("Ups... Something went wrong");
    }

    pause("\t|> Presione Enter para continuar!");
  }
}
