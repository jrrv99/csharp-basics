namespace _Termoelectrica
{
  class Termoelectrica
  {
    private List<double> temperaturas;

    public Termoelectrica()
    {
      temperaturas = new List<double>();
    }

    public void addTemp(double temp)
    {
      temperaturas.Add (temp);
    }

    public double getMin()
    {
      temperaturas.Sort();
      return temperaturas.First();
    }

    public double getMax()
    {
      temperaturas.Sort();
      return temperaturas.Last();
    }

    public double getPromedio()
    {
      double sum = 0;
      foreach (int temp in temperaturas)
      {
        sum += temp;
      }

      return sum / temperaturas.Count;
    }
  }
}
