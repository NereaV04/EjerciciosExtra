using ModelsVideojuego;

class MenuVideojuego
{
    private List<Personaje> personajes;
    private const int OpcionSalir = 5;

    public MenuVideojuego()
    {
        personajes = new List<Personaje>();
        cargarPersonajes();
    }

    public void MostrarMenu()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("\n==== VIDEOJUEGO ====\n");
            Console.WriteLine("1. Registrar guerrrero.");
            Console.WriteLine("2. Registrar mago.");
            Console.WriteLine("3. Registrar arquero.");
            Console.WriteLine("4. Listar personajes.");
            Console.WriteLine("5. Salir.");
            Console.WriteLine("\n¿Qué quieres hacer? ");

            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > OpcionSalir)
            {
                Console.WriteLine("Error; seleccione una opción válida (1-5).");
            }

            switch (opcion)
            {
                case 1:
                    registrarGuerrero();
                    break;

                case 2:
                    registrarMago();
                    break;

                case 3:
                    registrarArquero();
                    break;

                case 4:
                    listarPersonajes();
                    break;

                case OpcionSalir:
                    Console.WriteLine("¡Hasta la próxima!");
                    break;
            }

        } while (opcion != OpcionSalir);
    }

    private void cargarPersonajes()
    {
        personajes.Add(new Guerrero("Aobozu", 920, 385));
        personajes.Add(new Guerrero("Yuki", 807, 300));
        personajes.Add(new Arquero("Hakuro", 950, 7));
        personajes.Add(new Arquero("Youko", 850, 4));
        personajes.Add(new Mago("Tamamonomae", 900, 200));
        personajes.Add(new Mago("Aori", 820, 100));
    }

    private void registrarGuerrero()
    {
        Guerrero guerrero = new Guerrero(pedirNombre(), pedirVidaFuerzaFlechasMana("Vida"), pedirVidaFuerzaFlechasMana("Fuerza"));
        personajes.Add(guerrero);
    }

    private void registrarMago()
    {
        Mago mago = new Mago(pedirNombre(), pedirVidaFuerzaFlechasMana("Vida"), pedirVidaFuerzaFlechasMana("Mana: "));
        personajes.Add(mago);
    }

    private void registrarArquero()
    {
        Arquero arquero = new Arquero(pedirNombre(), pedirVidaFuerzaFlechasMana("Vida"), pedirVidaFuerzaFlechasMana("Nº flechas: "));
        personajes.Add(arquero);
    }

    private string pedirNombre()
    {
        bool datoValido;
        string nombre;
        do
        {
            datoValido = true;
            Console.WriteLine("Nombre guerrero: ");
            nombre = Console.ReadLine();

            if (nombre is null || nombre == "")
            {
                Console.WriteLine("Error; introduce un nombre.");
                datoValido = false;
            }
        } while (!datoValido);

        return nombre;
    }


    private int pedirVidaFuerzaFlechasMana(string extra)
    {
        bool datoValido;
        int valor;
        do
        {
            datoValido = true;
            Console.WriteLine($"{extra}: ");
            if (!int.TryParse(Console.ReadLine(), out valor) || valor < 0)
            {
                Console.WriteLine("Error; escribe un valor válido (mayor que 0).");
                datoValido = false;
            }
        } while (!datoValido);
        return valor;
    }

    private void listarPersonajes()
    {
        Console.WriteLine("\n**** LISTADO ****\n");
        foreach (Personaje personaje in personajes)
        {
            Console.WriteLine(personaje.ObtenerDescripcion());
        }
    }
}