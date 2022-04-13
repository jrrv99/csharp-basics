using _Custom;
using Contactos;

namespace _Agenda
{
    class Agenda : Custom
    {
        private List<Contacto> contactos;

        public Agenda()
        {
            this.contactos = new List<Contacto>();
        }

        public bool createContact(Contacto contacto)
        {
            if (alreadyExist(contacto.getTelefono()) != -1)
            {
                return false;
            }
            contactos.Add (contacto);
            return true;
        }

        public bool deleteContact(string number)
        {
            int contactIndex = alreadyExist(number);

            if (contactIndex == -1)
            {
                return false;
            }

            contactos.RemoveAt (contactIndex);
            return true;
        }

        public void searchContacts(string number)
        {
            int index;
            bool b = false;
            writeLine("\n******* Coincidencias *******");
            foreach (Contacto c in contactos)
            {
                index = contactos.IndexOf(c);
                
                if (c.verifyContain(number))
                {
                    writeLine($"Contacto {index + 1}");
                    c.imprimirContacto();
                    b = true;
                }
            }

            if (!b)
            {
                writeLine("No se encontró ninguna coincidencia");
            }
        }

        public void listarContacts()
        {
            int index;

            if (contactos.Count == 0)
            {
                writeLine("No existen contactos aun");
                return;
            }

            writeLine("******* Lista de contactos *******");
            foreach (Contacto c in contactos)
            {
                index = contactos.IndexOf(c);
                writeLine($"Contacto {index + 1}");
                c.imprimirContacto();
            }
        }

        public int alreadyExist(string telefono)
        {
            foreach (Contacto c in contactos)
            {
                if (c.verifyNumber(telefono))
                {
                    return contactos.IndexOf(c);
                }
            }
            return -1;
        }
    }
}
