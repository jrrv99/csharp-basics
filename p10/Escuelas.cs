using _Custom;
using Users;

namespace Escuelas
{
  class Escuela : Custom
  {
    List<User> users;

    public Escuela()
    {
      users = new List<User>();
    }

    public void createUser(string name)
    {
      users.Add(new User(name));
    }

    public void presentarCurso(int userId, bool aprobado)
    {
      users[userId].setInscrito();
      if (aprobado)
      {
        users[userId].setAprobado();
      }
    }

    public void listaQuePresentaron()
    {
      writeLine("******* Lista de usuarios que han presentado *******\n");
      foreach (User u in users)
      {
        if (u.inscrito)
        {
          u.printUser();
        }
      }
    }

    public void printUsers()
    {
      writeLine("******* Lista de usuarios *******");
      foreach (User u in users)
      {
        writeLine($"User {users.IndexOf(u)}:");
        u.printUser();
      }
    }
  }
}
