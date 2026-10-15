using ModelsStreaming;

class MenuStreaming
{
    private List<Contenido> listaPlataforma;
    private const int OpcionSalir = 7;

    public MenuStreaming()
    {
        listaPlataforma = new List<Contenido>();
        cargarContenido();
    }

    public void MostrarMenu()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n==== PLATAFORMA DE STREAMING ====\n");
            Console.WriteLine("1. Añadir película.");
            Console.WriteLine("2. Añadir serie.");
            Console.WriteLine("3. Añadir documental.");
            Console.WriteLine("4. Listar contenido.");
            Console.WriteLine("5. Buscar contenido por título.");
            Console.WriteLine("6. Mostrar solo películas.");
            Console.WriteLine("7. Salir.");
            Console.WriteLine("\nSeleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > OpcionSalir)
            {
                Console.WriteLine($"Error; seleccione una opción válida (1-{OpcionSalir}).");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    registrarPelicula();
                    break;

                case 2:
                    registrarSerie();
                    break;

                case 3:
                    registrarDocumental();
                    break;

                case 4:
                    listarContenido();
                    break;

                case 5:
                    buscarPorTitulo();
                    break;
                case 6:
                    filtrarPeliculas();
                    break;

                case OpcionSalir:
                    Console.WriteLine("¡Hasta la próxima!");
                    break;
            }

        } while (opcion != OpcionSalir);
    }

    private void filtrarPeliculas()
    {
        
    }
    private void buscarPorTitulo()
    {
        string tituloABuscar = pedirString("Ingrese el título a buscar: ");
        List<Contenido> resultados = new List<Contenido>();

        foreach (Contenido contenido in listaPlataforma)
        {
            if (contenido.Titulo.ToLower().Equals(tituloABuscar.ToLower()))
            {
                resultados.Add(contenido);
            }
        }

        if (resultados.Count == 0)
        {
            Console.WriteLine($"No se encontró contenido con el título '{tituloABuscar}'.");
        }
        else
        {
            Console.WriteLine($"\nContenido encontrado:\n");
            foreach (Contenido contenido in resultados)
            {
                Console.WriteLine(contenido.ObtenerDescripcion());
            }
        }

    }

    private void registrarPelicula()
    {
        Pelicula pelicula = new Pelicula(pedirString("Título de la película: "), pedirInt("Duración de la película: "), pedirString("Director de la película: "));
        listaPlataforma.Add(pelicula);
    }

    private void registrarSerie()
    {
        Serie serie = new Serie(pedirString("Título de la serie: "), pedirInt("Duración de la serie: "), pedirInt("Cantidad de temporadas: "));
        listaPlataforma.Add(serie);
    }

    private void registrarDocumental()
    {
        Documental documental = new Documental(pedirString("Título del documental: "), pedirInt("Duración del documental: "), pedirString("Temática del documental: "));
        listaPlataforma.Add(documental);
    }

    private string pedirString(string textoAMostrar)
    {
        string texto;
        bool esValido;
        do
        {
            esValido = true;
            Console.WriteLine($"{textoAMostrar}");
            texto = Console.ReadLine();

            if (texto is null || texto.Trim().Length == 0)
            {
                Console.WriteLine("Error; el texto no puede estar vacío.");
                esValido = false;
            }

        } while (!esValido);
        return texto.Trim();
    }

    private int pedirInt(string textoAMostrar)
    {
        int valor;
        bool esValido;
        do
        {
            esValido = true;
            Console.WriteLine($"{textoAMostrar}");

            if (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
                Console.WriteLine("Error; escribe un valor válido (mayor que 0).");
                esValido = false;
            }

        } while (!esValido);
        return valor;
    }

    private void listarContenido()
    {
        if (listaPlataforma.Count == 0)
        {
            Console.WriteLine("No hay contenido registrado.");
            return;
        }

        Console.WriteLine("\n**** CONTENIDO STREAMING ****\n");
        foreach (Contenido contenido in listaPlataforma)
        {
            Console.WriteLine(contenido.ObtenerDescripcion());
        }
    }

    private void cargarContenido()
    {
        listaPlataforma.Add(new Pelicula("Annabelle", 99, "John R. Leonetti"));
        listaPlataforma.Add(new Pelicula("IT", 135, "Andrés Muschietti"));
        listaPlataforma.Add(new Serie("La maldición de Hill House", 50, 1));
        listaPlataforma.Add(new Serie("American Horror Story", 60, 13));
        listaPlataforma.Add(new Documental("The Keepers", 60, "Crimen real"));
    }
}