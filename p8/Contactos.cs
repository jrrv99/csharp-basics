using _Custom;

namespace Contactos
{
    class Contacto: Custom
    {
        public string nombre;

        private string telefono;

        protected string organization;

        public Contacto(string nombre, string telefono, string organization)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.organization = organization;
        }

        public string getTelefono() { return this.telefono; }

        public string getOrganization() { return this.organization; }

        public void imprimirContacto() {
            writeLine($"\tNombre: {nombre}");
            writeLine($"\tTelefono: {telefono}");
            writeLine($"\tOrganization: {organization}\n");
        }
        public bool verifyNumber(string number)
        {
            return (number == this.telefono);
        }

        public bool verifyContain(string number)
        {
            return (telefono.Contains(number));
        }
    }
}
