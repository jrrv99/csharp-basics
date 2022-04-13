namespace Figures
{
  abstract class Figure
  {
    public double altura;
    public double b;

    public abstract double getArea ();
  }

  class Rectangulo: Figure
  {
    public Rectangulo (double b, double altura) {
      this.altura = altura;
      this.b = b;
    }

    public override double getArea () {
      return (this.b * this.altura);
    }
  }

  class Triangulo: Figure
  {
    public Triangulo (double b, double altura) {
      this.altura = altura;
      this.b = b;
    }

    public override double getArea () {
      return ((this.b * this.altura)/2);
    }
  }

  

  class Trapecio: Figure
  {
    public double b2;
    
    public Trapecio (double b, double b2, double altura) {
      this.altura = altura;
      this.b = b;
      this.b2 = b2;
    }

    public override double getArea () {
      return (((this.b + this.b2) * this.altura)/2);
    }
  }
}