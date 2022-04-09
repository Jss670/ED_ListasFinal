using ListasSimplementeLigadas;

Lista listas = new Lista();
listas.AgregarNodo("uno");
listas.AgregarNodo("dos");
listas.AgregarNodo("tres");
Console.WriteLine(listas.RecorrerLista());
Console.WriteLine("buscando nodo dos");
Nodo nodoDos = listas.Buscar("dos");
Console.WriteLine(nodoDos.Valor);
Console.WriteLine("borrando dos");
listas.BorrarNodo("dos");
Console.WriteLine(listas.RecorrerLista());
