using _Custom;

namespace Vehiculos
{
  class Vehiculo : Custom
  {
    public string clientName;

    public string modelo;

    public string matricula;

    public bool parqueado;

    public Vehiculo(string clientName, string matricula, string modelo)
    {
      this.matricula = matricula;
      this.modelo = modelo;
      this.parqueado = true;
    }

    public bool setParqueado()
    {
      parqueado = !parqueado;
      return parqueado;
    }

    public bool verifyMatricula(string matricula)
    {
      return (matricula == this.matricula);
    }

    public bool compareMatricula(string matricula)
    {
      return (this.matricula.Contains(matricula));
    }

    public void printVehiculo()
    {
      writeLine($"\tPropietario: {clientName}");
      writeLine($"\tModelo: {modelo}");
      writeLine($"\tMatricula: {matricula}");
      writeLine($"\tParqueado: {(parqueado ? "Si" : "No")}\n");
    }
  }
}
