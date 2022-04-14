using _Custom;
using Escuelas;

class Program : Custom
{
  public static void Main()
  {
    mainAction();
  }

  public static void mainAction()
  {
    Escuela escuela = new Escuela();
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
          registrarUser (escuela);
          break;
        case 2:
          registrarUserEnCurso (escuela);
          break;
        case 3:
          consultarPresentados (escuela);
          break;
        case 4:
          consultar (escuela);
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
    writeLine("\t 1.- Registrar usuario");
    writeLine("\t 2.- Presentar curso");
    writeLine("\t 3.- Lista de usuarios que han presentado");
    writeLine("\t 4.- Consultar resultado del curso");
    writeLine("\t 0.- Salir");
    write("\n Ingrese una opcion: ");
  }

  public static void registrarUser(Escuela escuela)
  {
    string name;

    writeLine("******** Registro de Usuario ********");

    write("Nombre: ");
    name = Console.ReadLine();

    escuela.createUser(name);

    clear();

    writeLine("Se ha agregado correctamente");

    pause("\nPresione ENTER para volver al menu principal");
  }

  public static void registrarUserEnCurso(Escuela escuela)
  {
    int userId;
    bool aprobado;
    escuela.printUsers();

    write("Ingrese numero de usuario: ");
    userId = int.Parse(Console.ReadLine());

    write("Aprobo el curso? (s/Si - n/No): ");
    aprobado = (Console.ReadLine() == "s") ? true : false;

    escuela.presentarCurso (userId, aprobado);

    clear();

    write("Se ha registrado el usuario en el curso");

    pause("\nPresione ENTER para volver al menu principal");
  }

  public static void consultarPresentados(Escuela escuela)
  {
    escuela.listaQuePresentaron();

    pause("\nPresione ENTER para volver al menu principal");
  }

  public static void consultar(Escuela escuela)
  {
    escuela.printUsers();

    pause("\nPresione ENTER para volver al menu principal");
  }
}
