using _Custom;
using _Colpensiones;

class Program : Custom
{
  public static void Main()
  {
    Colpensiones empresa = new Colpensiones();
    (string name, int age) user;
    int cantUsers;

    writeLine("*** Sistema de COLPENSIONES ***\n");

    write("Cuantos usuarios desea ingresar? ");
    cantUsers = int.Parse(Console.ReadLine());

    for (int i = 1; i <= cantUsers; i++)
    {
      writeLine($"\n Usuario {i}");

      write("\t Nombre: ");
      user.name = Console.ReadLine();

      write("\t Edad: ");
      user.age = int.Parse(Console.ReadLine());

      empresa.createUser(user.name, user.age);
    }

    cantUsers = empresa.jubilados();

    writeLine("");
    writeLine($"Pueden jubilarse: {cantUsers}");
    writeLine($"No pueden jubilarse: {empresa.usersLen() - cantUsers}");
  }
}
