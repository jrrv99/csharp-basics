using _Custom;

namespace Tortas
{
  class Torta: Custom
  {
    public string sabor;

    public int porciones;

    public int porcionesDisponibles;

    public string decoracion;

    public int vendidas;

    public Torta(string sabor, int porciones, string decoracion)
    {
      this.sabor = sabor;
      this.porciones = porciones;
      this.decoracion = decoracion;
      this.porcionesDisponibles = porciones;
      this.vendidas = 0;
    }

    public int setPorcionesDiponibles {set => porcionesDisponibles += value;}

    public int setVendidas {
      set {
        porcionesDisponibles -= value;
        vendidas += value;
      }
    }

    public void printTorta() {
      writeLine($"\tSabor: {sabor}");
      writeLine($"\tPorciones: {porciones}");
      writeLine($"\tPorciones disponibles: {porcionesDisponibles}");
      writeLine($"\tDecoracion: {decoracion}\n");
    }
  }
}
