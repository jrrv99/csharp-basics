namespace Users
{
  class User
  {
    private int id;

    public string name;

    public List<int> peliculasAlquiladas;

    public User(int id, string name)
    {
      this.id = id;
      this.name = name;
      peliculasAlquiladas = new List<int>();
    }

    public int getId => id;

    public void addPeli(int peliId)
    {
      peliculasAlquiladas.Add (peliId);
    }

    public void removePeli(int peliId)
    {
      peliculasAlquiladas.Remove (peliId);
    }
  }
}
