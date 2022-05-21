using _Custom;
using _Termoelectrica;

class Program: Custom
{
  public static void Main() {
    Termoelectrica Termoelectrica = new Termoelectrica();
    int temps = 0;

    writeLine("*** TERMOELECTRICA ***\n");

    write("Cuantas temperaturas ingresara? ");
    temps = int.Parse(Console.ReadLine());

    for (int i = 1; i <= temps; i++)
    {
      write($"\t temperatura {i}: ");
      Termoelectrica.addTemp(double.Parse(Console.ReadLine()));
    }

    writeLine($"");
    writeLine($"Temperatura Maxima: {Termoelectrica.getMax()}");
    writeLine($"Temperatura Minima: {Termoelectrica.getMin()}");
    writeLine($"Promedio de temperaturas: {Termoelectrica.getPromedio()}");
  }
}
