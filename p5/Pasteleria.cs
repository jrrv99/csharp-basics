using _Custom;
using Tortas;

namespace _Pasteleria
{
  class Pasteleria : Custom
  {
    private List<Torta> tortas;

    public Pasteleria()
    {
      tortas =
        new List<Torta>()
        {
          new Torta("Fresa", 10, "Chantilli?!"),
          new Torta("Chocolate", 10, "Marmoleada?!"),
          new Torta("Sabor", 10, "Decoracion?!")
        };

      tortas[1].porcionesDisponibles = 0;
    }

    public void printTortas(int mood)
    {
      writeLine("****** Tortas Disponibles ******\n");

      foreach (Torta t in tortas)
      {
        if (t.porcionesDisponibles < 1 && mood == 1)
        {
          continue;
        }

        writeLine($"Torta {tortas.IndexOf(t)}:");
        t.printTorta();
      }
    }

    public void printTorta(int tortaId)
    {
      tortas[tortaId].printTorta();
    }

    public int disponibles(int tortaId)
    {
      return tortas[tortaId].porcionesDisponibles;
    }

    public void venderTorta(int tortaId, int cantidad)
    {
      tortas[tortaId].setVendidas = cantidad;
    }

    public void printEstadisticas()
    {
      clear();

      writeLine("****** Tortas Vendidas ******\n");

      foreach (Torta t in tortas)
      {
        if (t.vendidas > 0)
        {
          writeLine($"Torta {tortas.IndexOf(t)}:");
          writeLine($"\tSabor: {t.sabor}");
          writeLine($"\tDecoracion: {t.decoracion}");
          writeLine($"\tVendidas: {t.vendidas}\n");
        }
      }
    }

    public void createTorta(string sabor, int porciones, string decoracion)
    {
      tortas.Add(new Torta(sabor, porciones, decoracion));
    }

    public void agregarPorciones(int tortaId, int cantidad)
    {
      tortas[tortaId].setPorcionesDiponibles = cantidad;
    }
  }
}
