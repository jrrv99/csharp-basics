using System;
using _Custom;
using _Agenda;
using Contactos;

class Program : Custom
{
    public static void Main(string[] args)
    {
        mainAction();
    }

    public static void mainAction()
    {
        Agenda agenda = new Agenda();
        int opt = -1;
        do
        {
            mainMenu();
            opt = int.Parse(Console.ReadLine());

            switch (opt)
            {
                case 0: //Salir
                    clear();
                    pause("¡Hasta Luego! \n¡Presione Enter para Salir!");
                    break;
                case 1:
                    agregarContacto (agenda);
                    break;
                case 2:
                    buscarContactos (agenda);
                    break;
                case 3:
                    eliminarContactos (agenda);
                    break;
                case 4:
                    listarContactos (agenda);
                    break;
                default:
                    pause("¡Ingrese una opcion validad! \n¡Presione Enter!");
                    break;
            }
        }
        while (opt != 0);
    }

    public static void mainMenu()
    {
        clear();
        writeLine("**** Agenda de contactos **** \n");
        writeLine("\t 1.- Agregar contacto");
        writeLine("\t 2.- Buscar contacto");
        writeLine("\t 3.- Eliminar contacto");
        writeLine("\t 4.- Lista de contactos");
        writeLine("\t 0.- Salir");
        write("\n Ingrese una opcion: ");
    }

    public static void agregarContacto(Agenda agenda)
    {
        (string nombre, string telefono, string organization) contacto;
        int opt = -1;

        do
        {
            contacto = menuAddContact();
            if (
                !agenda
                    .createContact(new Contacto(contacto.nombre,
                        contacto.telefono,
                        contacto.organization))
            )
            {
                writeLine("El contacto ya existe\n");
                pause("¡Presione Enter para volver al menu!");
                break;
            }

            writeLine("Se ha agregado un nuevo contacto");
            writeLine($"\tNombre: {contacto.nombre}");
            writeLine($"\tTelefono: {contacto.telefono}");
            writeLine($"\tOrganization: {contacto.organization}");

            pause("\n¡Presione Enter para continuar!...");

            writeLine("\t 1 .- Agregar otro contacto");
            writeLine("\t 0 .- Volver al menu principal");
            write("\n Ingrese una opcion: ");
            opt = int.Parse(Console.ReadLine());
        }
        while (opt != 0);
    }

    public static (string nombre, string telefono, string organization)
    menuAddContact()
    {
        (string nombre, string telefono, string organization) contacto;
        clear();
        writeLine("***** Añadir nuevo contacto *****\n");

        write("\tNombre completo: ");
        contacto.nombre = Console.ReadLine();

        write("\tNumero telefonico: ");
        contacto.telefono = Console.ReadLine();

        write("\tOrganizacion: ");
        contacto.organization = Console.ReadLine();

        clear();

        return contacto;
    }

    public static void buscarContactos(Agenda agenda)
    {
        clear();
        writeLine("******* Buscar contactos *******");
        write("Ingrese un numero: ");
        string number = Console.ReadLine();

        agenda.searchContacts(number);

        pause("\n¡Presione enter para continuar");
    }

    public static void eliminarContactos(Agenda agenda)
    {
        clear();
        writeLine("Ingrese el numero que desea eliminar");
        write("_: ");
        string number = Console.ReadLine();

        if (agenda.deleteContact(number))
        {
            writeLine("\nEl numero ha sido eliminado correctamente!");
        }
        else
        {
            writeLine("\nHa ocurrido un error al eliminar el numero");
        }

        pause("\n¡Presione Enter para continuar!");
    }

    public static void listarContactos(Agenda agenda)
    {
        clear();
        agenda.listarContacts();

        pause("\n¡Presione Enter para volver al menu principal!...");
    }
}
