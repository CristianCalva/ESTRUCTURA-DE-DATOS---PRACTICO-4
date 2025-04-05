
class NodoArbol
{
    public int Valor; // Valor almacenado en el nodo
    public List<NodoArbol> Hijos; // Lista de hijos del nodo

    // Constructor para inicializar el nodo con un valor dado
    public NodoArbol(int valor)
    {
        Valor = valor;
        Hijos = new List<NodoArbol>();
    }

    // Método para agregar un hijo al nodo actual
    public void AgregarHijo(NodoArbol hijo)
    {
        Hijos.Add(hijo);
    }
}

// Clase para manejar el árbol y su impresión
class Arbol
{
    public NodoArbol Raiz; // Nodo raíz del árbol

    // Constructor que inicializa el árbol con un nodo raíz
    public Arbol(int valorRaiz)
    {
        Raiz = new NodoArbol(valorRaiz);
    }

    // Método para imprimir el árbol en forma jerárquica en consola
    public void ImprimirArbol(NodoArbol nodo, string prefijo = "", bool esUltimo = true)
    {
        Console.WriteLine(prefijo + (esUltimo ? "└── " : "├── ") + nodo.Valor);
        
        for (int i = 0; i < nodo.Hijos.Count; i++)
        {
            // Llamado recursivo para imprimir los hijos
            ImprimirArbol(nodo.Hijos[i], prefijo + (esUltimo ? "    " : "│   "), i == nodo.Hijos.Count - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        // Ejemplo 1: Creación de un árbol simple
        Arbol arbol1 = new Arbol(1);
        NodoArbol nodo2 = new NodoArbol(2);
        NodoArbol nodo3 = new NodoArbol(3);
        NodoArbol nodo4 = new NodoArbol(4);
        NodoArbol nodo5 = new NodoArbol(5);

        // Construcción del árbol agregando nodos
        arbol1.Raiz. AgregarHijo(nodo2);
        arbol1.Raiz.AgregarHijo(nodo3);
        nodo2.AgregarHijo(nodo4);
        nodo2.AgregarHijo(nodo5);

        // Imprimir la estructura del primer árbol
        Console.WriteLine("Árbol 1:");
        arbol1.ImprimirArbol(arbol1.Raiz);

        // Ejemplo 2: Creación de otro árbol con estructura diferente
        Arbol arbol2 = new Arbol(10);
        NodoArbol nodo20 = new NodoArbol(20);
        NodoArbol nodo30 = new NodoArbol(30);
        NodoArbol nodo40 = new NodoArbol(40);
        NodoArbol nodo50 = new NodoArbol(50);
        NodoArbol nodo60 = new NodoArbol(60);

        // Construcción del segundo árbol agregando nodos
        arbol2.Raiz.AgregarHijo(nodo20);
        arbol2.Raiz.AgregarHijo(nodo30);
        nodo20.AgregarHijo(nodo40);
        nodo30.AgregarHijo(nodo50);
        nodo30.AgregarHijo(nodo60);

        // Imprimir la estructura del segundo árbol
        Console.WriteLine("\nÁrbol 2:");
        arbol2.ImprimirArbol(arbol2.Raiz);
    }
}
