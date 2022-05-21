namespace Usuarios
{
  class Usuario
  {
    public string name;

    public int age;

    public Usuario(string name, int age)
    {
      this.name = name;
      this.age = age;
    }

    public bool jubilarse()
    {
      return age >= 60;
    }
  }
}
