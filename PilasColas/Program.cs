//Arreglos.Pilas pilas = new Arreglos.Pilas(10);
//pilas.Agregar("cero");
//pilas.Agregar("uno");
//pilas.Agregar("dos");
//pilas.Agregar("tres");
//pilas.Agregar("cuatro");
//pilas.Agregar("cinco");
//Console.WriteLine(pilas.Imprimir());



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