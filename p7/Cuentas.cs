using _Custom;

namespace Cuentas
{
  class Cuenta: Custom
  {
    public string titular;
    private double cantidad;

    public Cuenta(string titular, double cantidad) {
      this.titular = titular;
      this.cantidad = cantidad;
    }

    public bool retirar(double retiro) {
      if (cantidad < retiro) { return false; }

      cantidad -= retiro;
      return true;
    }

    public double getCantidad => cantidad;

    public double setDeposito { set => cantidad += value; }

    public void printCuenta() {
      writeLine($"\tTitular: {titular}");
      writeLine($"\tCantidad: {cantidad}");
    }
  }
}