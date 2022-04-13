namespace Peliculas
{
  class Pelicula
  {
    protected int id;

    public string name;

    private bool status;

    protected string novedad;

    public Pelicula(int id, string name)
    {
      this.id = id;
      this.name = name;
      this.status = true;
      this.novedad = "Nueva!";
    }

    public int getId => id;

    public bool getStatus { get => status;}

    public bool setStatus {set => status = value;}

    public string getNovedad => novedad;

    public string setNovedad {set => novedad = value;}
  }
}
