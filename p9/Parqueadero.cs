using _Custom;
using Vehiculos;

namespace _Parqueadero
{
  class Parqueadero : Custom
  {
    private List<Vehiculo> vehiculos;

    public Parqueadero()
    {
      vehiculos = new List<Vehiculo>();
    }

    public bool
    createVehiculo(string clientName, string matricula, string modelo)
    {
      if (alreadyExist(matricula)) { return false; }

      vehiculos.Add(new Vehiculo(clientName, matricula, modelo));
      return true;
    }

    public bool alreadyExist(string matricula)
    {
      foreach (Vehiculo v in vehiculos)
      {
        if (v.verifyMatricula(matricula))
        {
          return true;
        }
      }
      return false;
    }

    public bool toggleParqueado(int vehiculoId)
    {
      return vehiculos[vehiculoId].setParqueado();
    }

    public void printVehiculos()
    {
      writeLine($"****** Vehiculos registrados ******\n");
      foreach (Vehiculo v in vehiculos)
      {
        writeLine($"  Vehiculo nro{vehiculos.IndexOf(v)}");
        v.printVehiculo();
      }
    }
    
    public void consultar(string matricula)
    {
      bool theresCoincidence = false;
      writeLine($"Coincidencias con: {matricula}\n");
      foreach (Vehiculo v in vehiculos)
      {
        if (!v.compareMatricula(matricula)) { continue; }

        theresCoincidence = true;
        writeLine($"  Vehiculo {vehiculos.IndexOf(v)}");
        v.printVehiculo();
      }

      if (!theresCoincidence) { writeLine("No hay coincidencias"); }

      pause("\nPresione ENTER para continuar");
    }

    public bool theresVehiculos () {
      return (vehiculos.Count > 0);
    }
  }
}
