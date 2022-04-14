using _Custom;

class Program: Custom
{
  public static void Main() {
    mainAction();
  }

  public static void mainAction() {
    //Instancia de HoC
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
          depositar (banco);
          break;
        case 2:
          retirar (banco);
          break;
        case 3:
          consultar (banco);
          break;
        default:
          pause("¡Ingrese una opcion validad! \n¡Presione Enter!");
          break;
      }
      }
    } while (opt != 0);
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

}