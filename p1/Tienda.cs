using _Custom;
using Peliculas;
using Users;

namespace Tiendas
{
  class Tienda : Custom
  {
    private List<Pelicula> peliculas;

    private List<User> users;

    public Tienda()
    {
      peliculas = new List<Pelicula>();
      users = new List<User>();
    }

    /**
      * * Peliculas
      */
    public void createPeli(string name)
    {
      peliculas.Add(new Pelicula(peliculas.Count, name));
    }

    public void printPelis()
    {
      clear();

      if (peliculas.Count == 0)
      {
        writeLine("Aun no hay peliculas");
        pause("\t|> Presione Enter para continuar!");
        return;
      }

      writeLine("\t******** Lista de peliculas ********\n");
      foreach (Pelicula p in peliculas)
      {
        writeLine($"  Pelicula {p.getId}");
        writeLine($"\tNombre: {p.name}");
        writeLine($"\tStatus: {(p.getStatus ? "Disponible!" : "Alquilada!")}");
        writeLine($"\tNovedades: {p.getNovedad}\n");
      }
    }

    /**
      * * Users
      */
    public void createUser(string name)
    {
      users.Add(new User(users.Count, name));
    }

    public void printUsers()
    {
      clear();

      if (users.Count == 0)
      {
        writeLine("Aun no hay usuarios");
        pause("\t|> Presione Enter para continuar!");
        return;
      }

      writeLine("\t******** Lista de Clientes ********\n");
      foreach (User u in users)
      {
        writeLine($"Usuario {u.getId}");
        writeLine($"\tNombre: {u.name}");
        writeLine($"\tPeliculas Alquiladas: {(u.peliculasAlquiladas).Count}\n");
      }
    }

    public bool peliDisp(int peliId)
    {
      return peliculas[peliId].getStatus;
    }

    public bool alquilarPeli(int userId, int peliId)
    {
      if (!peliculas[peliId].getStatus)
      {
        return false;
      }

      users[userId].addPeli(peliId);

      peliculas[peliId].setStatus = false;

      return true;
    }

    public bool retornarPeli(int userId, int peliId)
    {
      if (peliculas[peliId].getStatus)
      {
        return false;
      }

      users[userId].removePeli(peliId);

      peliculas[peliId].setStatus = true;

      return true;
    }

    public void listUsersInRent()
    {
      writeLine("Usuarios con peliculas rentadas\n");
      foreach (User u in users)
      {
        if ((u.peliculasAlquiladas).Count > 0)
        {
          writeLine($"Usuario {u.getId}");
          writeLine($"\tNombre: {u.name}");
          writeLine($"\tPeliculas Alquiladas: {(u.peliculasAlquiladas).Count}\n");
        }
      }
    }

    public void pelisPerUser(int userId)
    {
      foreach (int peliId in users[userId].peliculasAlquiladas)
      {
        writeLine($"  Pelicula {peliculas[peliId].getId}");
        writeLine($"\tNombre: {peliculas[peliId].name}");
        writeLine($"\tStatus: {(peliculas[peliId].getStatus ? "Disponible!" : "Alquilada!")}");
        writeLine($"\tNovedades: {peliculas[peliId].getNovedad}\n");
      }
    }

    public void addNovedad(int peliId, string novedad) {
      peliculas[peliId].setNovedad = novedad;
    }
  }
}
