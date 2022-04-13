using System;
using _Custom;
using _Parqueadero;

class Program : Custom
{
  public static void Main()
  {
    mainAction();
  }

  public static void mainAction()
  {
    Parqueadero parqueadero = new Parqueadero();
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
          registrarVehiculo (parqueadero);
          break;
        case 2:
          retirar (parqueadero);
          break;
        case 3:
          consultar (parqueadero);
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
    writeLine("**** Parqueadero El Guardian  **** \n");
    writeLine("\t 1.- Registrar nuevo Vehiculo");
    writeLine("\t 2.- Ingresar/Retirar Vehiculo");
    writeLine("\t 3.- Consultar estados");
    write("\n Ingrese una opcion: ");
  }

  public static void registrarVehiculo(Parqueadero parqueadero)
  {
    string
      clientName,
      matricula,
      modelo;
    clear();
    writeLine("***** Registro de nuevo vehiculo *****\n");
    write("\tNombre del propietario: ");
    clientName = Console.ReadLine();
    write("\tModelo: ");
    modelo = Console.ReadLine();
    write("\tMatricula: ");
    matricula = Console.ReadLine();

    clear();

    if (parqueadero.createVehiculo(clientName, matricula, modelo))
    {
      writeLine("Se ha registrado y parqueado correctamente");
    }
    else
    {
      writeLine("El vehiculo ya existe!");
    }

    pause("\nPresione ENTER para continuar");
  }

  public static void retirar(Parqueadero parqueadero)
  {
    parqueadero.printVehiculos();

    if (!parqueadero.theresVehiculos()) {
      writeLine("\tAun no hay vehiculos registrados");
      pause("\nPresione ENTER para volver al menu");
      return;
    }

    write("Ingrese el numero del vehiculo: ");
    bool p = parqueadero.toggleParqueado(int.Parse(Console.ReadLine()));

    clear();

    writeLine($"Se ha {(p ? "Parqueado" : "Retirado")} el vehiculo correctamente");
    pause("\nPresione ENTER para continuar");
  }

  public static void consultar(Parqueadero parqueadero)
  {
    writeLine("Consultar vehiculos en el parqueadero");
    write("Ingrese la matricula: ");
    parqueadero.consultar(Console.ReadLine());
  }
}
