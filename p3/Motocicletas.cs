using _Custom;

namespace Motocicletas
{
  class Motocicleta: Custom
  {
    public string clientName;

    public string registroDeIngreso;

    public string observacionesDelCliente;

    public bool onSite;

    public string registroDeSalida;

    public string arreglos;

    public Motocicleta(
      string clientName,
      string registroDeIngreso,
      string observacionesDelCliente
    )
    {
      this.clientName = clientName;
      this.registroDeIngreso = registroDeIngreso;
      this.observacionesDelCliente = observacionesDelCliente;
      onSite = true;
      registroDeSalida = "";
      arreglos = "";
    }

    public void toogleOnSite () { onSite = !onSite; }

    public void sellarSalida (string registroDeSalida, string arreglos) {
      this.registroDeSalida = registroDeSalida;
      this.arreglos = arreglos;
      toogleOnSite();
    }

    public void printData() {
      writeLine($"\t Propietario: {clientName}");
      writeLine($"\t Registro de Ingreso: {registroDeIngreso}");
      writeLine($"\t Observaciones del cliente: {observacionesDelCliente}");
      writeLine($"\t Estado: {(onSite ? "En reparacion\n" : "Entregado")}");
      if (!onSite)
      {        
        writeLine($"\t Registro de salida: {registroDeSalida}");
        writeLine($"\t Arreglos: {arreglos}\n");
      }
    }
  }
}
