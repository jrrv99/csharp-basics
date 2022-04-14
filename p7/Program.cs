using _Custom;
using Bancos;

class Program: Custom
{
  public static void Main() {
    mainAction();
  }

  public static void mainAction() {
    Banco banco = new Banco();
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
          registrar(banco);
          break;
        case 2:
          depositar (banco);
          break;
        case 3:
          retirar (banco);
          break;
        case 4:
          consultar (banco);
          break;
        default:
          pause("¡Ingrese una opcion validad! \n¡Presione Enter!");
          break;
      }
    } while (opt != 0);
  }

  public static void menu()
  {
    clear();
    writeLine("**** SU BANCO FIEL  **** \n");
    writeLine("\t 1.- Registrar nuevo titular");
    writeLine("\t 2.- Depositar");
    writeLine("\t 3.- Retirar");
    writeLine("\t 4.- Consultar saldo");
    writeLine("\t 0.- Salir");
    write("\n Ingrese una opcion: ");
  }

  public static void registrar(Banco banco) {
    string titular; double cantidad;
    writeLine("******* Registrar nuevo titular *******\n");

    write("\tNombre del titular: ");
    titular = Console.ReadLine();
    write("\tCantidad de deposito inicial: ");
    cantidad = double.Parse(Console.ReadLine());

    clear();

    if (!verificarDeposito(cantidad))
    {
      writeLine("Tiene que ingresar una cantidad no negativa");
      pause("\nPresione ENTER para continuar");
      return;
    }

    banco.createCuenta(titular, cantidad);

    writeLine("Se ha creado correctamente");
    pause("\nPresione ENTER para continuar");
  }

  public static void depositar (Banco banco) {
    int cuentaId; double cantidad;

    writeLine("******** Depositos ********\n");
    banco.printCuentas();

    write("Nro de cuenta para el deposito: ");
    cuentaId = int.Parse(Console.ReadLine());

    clear();
    writeLine($"Cuenta Nro {cuentaId}:");
    banco.printCuenta(cuentaId);

    write("Cantidad a depositar: ");
    cantidad = double.Parse(Console.ReadLine());

    clear();

    if (!verificarDeposito(cantidad))
    {
      writeLine("Tiene que ingresar una cantidad no negativa");
      pause("\nPresione ENTER para continuar");
      return;
    }

    banco.depositar(cuentaId, cantidad);

    writeLine($"Se ha cargado {cantidad} correctamente");
    pause("\nPresione ENTER para continuar");
  }

  public static void retirar (Banco banco) {
    int cuentaId; double cantidad;

    writeLine("******** Retiros ********\n");
    banco.printCuentas();

    write("Nro de cuenta para el retiro: ");
    cuentaId = int.Parse(Console.ReadLine());

    clear();
    writeLine($"Cuenta Nro {cuentaId}:");
    banco.printCuenta(cuentaId);

    write("Cantidad a retirar: ");
    cantidad = double.Parse(Console.ReadLine());

    clear();

    if (!verificarDeposito(cantidad))
    {
      writeLine("Tiene que ingresar una cantidad no negativa");
      pause("\nPresione ENTER para continuar");
      return;
    }

    if(!banco.retirar(cuentaId, cantidad)) {
      writeLine("Saldo no suficiente, intente con una cantidad menor");
    }
    else
    {
      writeLine($"Se ha retirado {cantidad} correctamente");
    }

    pause("\nPresione ENTER para continuar");
  }

  public static void consultar (Banco banco) {
    int cuentaId;
    writeLine("******** Consultar Estado de cuenta ********\n");
    banco.printCuentas();

    write("\nNumero de cuenta a consultar: ");
    cuentaId = int.Parse(Console.ReadLine());

    clear();

    banco.consultarCuenta(cuentaId);

    pause("\nPresione ENTER para continuar");
  }

  public static bool verificarDeposito(double cantidad) {
    return cantidad >= 0;
  }
}