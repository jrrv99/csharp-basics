using _Custom;
using Motocicletas;

namespace Talleres
{
  class Taller : Custom
  {
    private List<Motocicleta> motocicletas;

    public Taller()
    {
      motocicletas = new List<Motocicleta>();
    }

    public void registrarMoto(
      string clientName,
      string registroDeIngreso,
      string observacionesDelCliente
    )
    {
      motocicletas
        .Add(new Motocicleta(clientName,
          registroDeIngreso,
          observacionesDelCliente));
    }

    public void entregarMoto(
      int motoId,
      string registroDeSalida,
      string arreglos
    )
    {
      motocicletas[motoId].sellarSalida(registroDeSalida, arreglos);
    }

    public void printMotos()
    {
      clear();
      writeLine("********** Lista de Motos **********\n");

      if(!theresMotos()) {
        writeLine("Aun no hay motos en el taller");
        return;
      }

      foreach (Motocicleta m in motocicletas)
      {
        writeLine($"  Motocicleta {motocicletas.IndexOf(m)}:");
        m.printData();
      }
    }

    public bool theresMotos() {
      return motocicletas.Count > 0;
    }
  }
}
