Console.WriteLine("Pilas con arreglos");
Arreglos.Pilas pilas = new Arreglos.Pilas(10);
pilas.Agregar("cero");
pilas.Agregar("uno");
pilas.Agregar("dos");
pilas.Agregar("tres");
pilas.Agregar("cuatro");
pilas.Agregar("cinco");

for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("---------------");
        pilas.Eliminar();
        Console.WriteLine(pilas.Imprimir());
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
}




Console.WriteLine("Colas con arreglos");
Arreglos.Colas Colas = new Arreglos.Colas(10);
Colas.Agregar("cero");
Colas.Agregar("uno");
Colas.Agregar("dos");
Colas.Agregar("tres");
Colas.Agregar("cuatro");
Colas.Agregar("cinco");

for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("---------------");
        Colas.Eliminar();
        Console.WriteLine(Colas.Imprimir());
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
}


Console.WriteLine("Pilas con listas");
Listas.Pilas pilasLista = new Listas.Pilas();
pilasLista.Agregar("cero");
pilasLista.Agregar("uno");
pilasLista.Agregar("dos");
pilasLista.Agregar("tres");
pilasLista.Agregar("cuatro");
pilasLista.Agregar("cinco");

for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("------Listas---------");
        pilasLista.Eliminar();
        Console.WriteLine(pilasLista.Imprimir());
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
}


Console.WriteLine("Colas con listas");
Listas.Colas lstColas = new Listas.Colas();
lstColas.Agregar("cero");
lstColas.Agregar("uno");
lstColas.Agregar("dos");
lstColas.Agregar("tres");
lstColas.Agregar("cuatro");
lstColas.Agregar("cinco");

for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("---------------");
        lstColas.Eliminar();
        Console.WriteLine(lstColas.Imprimir());
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
}
