using System;
using System.Collections.Generic;

abstract class Custom
{
    public static void clear()
    {
        Console.Clear();
    }

    public static void write(object statement)
    {
        Console.Write (statement);
    }

    public static void writeLine(object statement)
    {
        Console.WriteLine (statement);
    }

    public static void pause(string message)
    {
        write (message);
        Console.ReadLine();
        clear();
    }
} //abstract class Custom

class Product
{
    public string name;

    public double price;

    public int stock;

    public Product(string name, double price, int stock)
    {
        this.name = name;
        this.price = price;
        this.stock = stock;
    }

    public bool vender(int unids)
    {
        if (stock >= unids)
        {
            stock -= unids;
            return true;
        }
        return false;
    }

    public void reembolzar(int unids)
    {
        this.stock += unids;
    }
}

class Program : Custom
{
    public static void Main(string[] args)
    {
        List<Product> products = fillProducts();

        mainAction (products);
    }

    public static List<Product> fillProducts()
    {
        List<Product> products = new List<Product>();

        (string name, double price, int stock)[] list =
        { ("harina", 1.75, 10), ("papel", 1.75, 10) };

        foreach ((string name, double price, int stock) l in list)
        {
            products.Add(new Product(l.name, l.price, l.stock));
        }

        return products;
    }

    public static void mainAction(List<Product> products)
    {
        List<(int index, string name, int unids)> buyedProducts =
            new List<(int index, string name, int unids)>();

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
                    buyProducts (products, buyedProducts);
                    break;
                case 2:
                    productsList (products);
                    break;
                case 3:
                    refundProducts (products, buyedProducts);
                    break;
                default:
                    pause("¡Ingrese una opcion validad! \n¡Presione Enter!");
                    break;
            }
        }
        while (opt != 0);
    }

    public static void buyProducts(
        List<Product> products,
        List<(int index, string name, int unids)> buyedProducts
    )
    {
        int prod = 0; int unids = 0;
        clear();

        writeLine("******** Comprar Producto ********");
        foreach (Product product in products)
        {
            if (product.stock > 0)
            {
                writeLine($"\t{products.IndexOf(product)}.- {product.name} (${product.price}) (disponibles: {products[prod].stock})");
            }
        }

        write("\n Elija un producto: ");
        prod = int.Parse(Console.ReadLine());

        write($"\n Cuantas unidades?: ");
        unids = int.Parse(Console.ReadLine());

        if (products[prod].vender(unids)) { buyedProducts.Add((prod, products[prod].name, unids)); }
        else { writeLine("\nUnidades no disponibles"); }

        pause("\n¡Presione Enter para volver al menu!");
    }

    public static void productsList(List<Product> products)
    {
        clear();
        writeLine("******* Products List *******\n");

        foreach (Product product in products)
        {
            if (product.stock > 0) {
                writeLine($"\t{product.name} ${product.price} stock: {product.stock}");
            }
        }

        pause("\n¡Presione Enter para volver al menu!");
    }

    public static void refundProducts(
        List<Product> products,
        List<(int index, string name, int unids)> buyedProducts
    )
    {
        int prod =0;

        clear();
        writeLine("******** Devolver Producto ********\n");

        if(buyedProducts.Count > 0){
            foreach ((int index, string name, int unids) bp in buyedProducts)
            {
                writeLine($"\t{buyedProducts.IndexOf(bp)}.- {bp.name} ({bp.unids})");
            }

            write("\n Elija un producto: ");
            prod = int.Parse(Console.ReadLine());

            products[prod].reembolzar(buyedProducts[prod].unids);
            buyedProducts.RemoveAt(prod);

            writeLine("\n Se ha devuelto el producto.");
        } else
        {
            writeLine("\n No ha comprado productos aún.");
        }

        pause("\n¡Presione Enter para volver al menu!");
    }

    public static void mainMenu()
    {
        clear();
        writeLine("**** Droguería Mi Salud **** \n");
        writeLine("\t 1.- Comprar Producto");
        writeLine("\t 2.- Lista de Precios");
        writeLine("\t 3.- Devolución de producto");
        writeLine("\t 0.- Salir");
        write("\nIngrese una opcion: ");
    } // mainMenu ()
}
