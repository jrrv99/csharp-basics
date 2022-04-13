namespace Personas
{
    class Persona
    {
        public double peso;

        public double estatura;

        public Persona(double peso, double estatura)
        {
            this.peso = peso;
            this.estatura = estatura;
        }

        public double getImc () {
            return (this.peso/Math.Pow(this.estatura, 2));
        }

        public string getRange() {
            double imc = getImc();

            if (imc < 20) { return "BAJO PESO"; }
            if (20 <= imc && imc < 25) { return "NORMAL"; }
            if (25 <= imc && imc < 29.9) { return "SOBRE PESO"; }
            
            return "OBESO";
        }
    }
}


/**
  * 70/x = 21.6
  */