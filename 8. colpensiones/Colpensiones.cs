using Usuarios;

namespace _Colpensiones
{
  class Colpensiones
  {
    private List<Usuario> usuarios;

    public Colpensiones()
    {
      usuarios = new List<Usuario>();
    }

    public void createUser(string name, int age)
    {
      usuarios.Add(new Usuario(name, age));
    }

    public int jubilados()
    {
      int jubilados = 0;
      foreach (Usuario user in usuarios)
      {
        jubilados += user.jubilarse() ? 1 : 0;
      }

      return jubilados;
    }

    public int usersLen()
    {
      return usuarios.Count;
    }
  }
}
