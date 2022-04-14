using Cuentas;
using _Custom;

namespace Bancos
{
  class Banco: Custom
  {
    List<Cuenta> cuentas;

    public Banco() {
      cuentas = new List<Cuenta>();
    }

    public void createCuenta(string titular, double cantidad) {
      cuentas.Add(new Cuenta(titular, cantidad));
    }

    public void depositar(int cuentaId, double cantidad) {
      cuentas[cuentaId].setDeposito = cantidad; //+cantidad
    }

    public bool retirar(int cuentaId, double cantidad) {
      return cuentas[cuentaId].retirar(cantidad); //-cantidad
    }

    public void printCuentas() {
      foreach (Cuenta c in cuentas)
      {
        writeLine($"  Cuenta nro: {cuentas.IndexOf(c)}");
        writeLine($"\tTitular: {c.titular}\n");
      }
    }

    public void printCuenta(int cuentaId) {
      cuentas[cuentaId].printCuenta();
    }

    public void consultarCuenta(int cuentaId) {
      writeLine($"Cuenta nro {cuentaId}:");
      cuentas[cuentaId].printCuenta();
    }
  }
}