using _Custom;

namespace Users
{
  class User: Custom
  {
    public string name;
    public bool inscrito;
    public bool aprobado;

    public User (string name) {
      this.name = name;
      inscrito = false;
      aprobado = false;
    }

    public void setInscrito() {
      inscrito = !inscrito;
    }

    public void setAprobado () {
      aprobado = !aprobado;
    }

    public void printUser() {
      writeLine($"\tNombre: {name}");
      writeLine($"\tInscrito: {(inscrito ? "Si" : "No")}");
      writeLine($"\tAprobado: {(aprobado ? "Si" : "No")}\n");
    }
  }
}