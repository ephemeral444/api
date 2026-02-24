class Program
{
    static void Main(string[] args)
    {
        Heroe Multico = new Heroe()
        {
           Nombre = "Multico",
           Apodo = "Multico de Elementel",
           Salud = 5000,
           Estatura = 1.70,
           TonoPiel = "Blanco",
           Aliados = "El equipo elemental",
           CaminoHeroico = "Recuperar los elementos robados",
           Elemento = "Multielemental",
        };

        Multico.Habilidades.Add(new Habilidad
        {
            Habilidades = "Pulso elemental",
            Movilidad = "Volar",
            Danio = "Absorbente",
            Arma = "Espada elemental",
            Especial = "Carga elemental",
        });

        Villano Caopton = new Villano()
        {
            Nombre = "Caopton",
            Apodo = "El señor del caos",
            Salud = 500000,
            Estatura = 1.75,
            TonoPiel = "Blanco",
            Aliados = "Portadores malvados",
            Trasfondo = "Violencia, Bullyng, Muerte, Abuso",
            Elemento = "Caos",
        };

        Caopton.Habilidades.Add(new Habilidad
        {
            Habilidades = "Control del caos",
            Movilidad = "Omnipresente",
            Danio = "Caos",
            Arma = "Garras del caos",
            Especial = "Control espacio tiempo absoluto",
        });

        AntiHeroe Vortex = new AntiHeroe()
        {
            Nombre = "Vortex",
            Apodo = "Demonio de Elementel",
            Salud = 1000000000,
            Estatura = 1.70,
            TonoPiel = "Blanco",
            Aliados = "Ninguno. El es su propio aliado",
            Elemento = "23 elementos de la barra",
            Inclinacion = "Heroe",
            Apariencia = "Aunque no tenga intenciones malvadas, su apariencia es peor a la de un villano",
            Motivacion = "Asesinar a todos los villanos, usar el poder absoluto y traer de regreso a todos los que perdio",
        };

        Vortex.Habilidades.Add(new Habilidad
        {
            Habilidades = "Control sanguineo - Endurecimiento",
            Movilidad = "Demasiado rapido",
            Danio = "Perforante",
            Arma = "Sus propias manos y sangre endurecida",
            Especial = "Mega carga elemental absoluta",
        });

        Heroe Firestorm = new Heroe()
        {
            Nombre = "Firestorm",
            Apodo = "El fenix",
            Salud = 4500,
            Estatura = 1.70,
            TonoPiel = "Moreno",
            Aliados = "El equipo elemental",
            Elemento = "Fuego",
            CaminoHeroico = "Recuperar los elementos robados / Derrotar a Caopton",
        };

        Firestorm.Habilidades.Add(new Habilidad
        {
            Habilidades = "Torbellino igneo - Persecucion ignea",
            Movilidad = "Rapido gracias a sus botas de magma",
            Danio = "Quemadura",
            Arma = "Cestus de magma",
            Especial = "Deflagracion",
        });

        Villano Thunderman = new Villano()
        {
            Nombre = "Thunderman",
            Apodo = "Voltio loco",
            Salud = 10000,
            Estatura = 1.68,
            TonoPiel = "Palido",
            Aliados = "Los mismos villanos que el crea y los portadores malvados",
            Elemento = "Electrico",
            Trasfondo = "Manipulacion, Control, Maltrato psicologico"
        };

        Thunderman.Habilidades.Add(new Habilidad
        {
            Habilidades = "Sobrecarga de voltios (Puede sobrecargarse con mas de 1'000.000 de voltios)",
            Movilidad = "Igual de rapido que la velocidad de la luz",
            Danio = "Electrico / Aturdimiento",
            Arma = "Tridente de energia",
            Especial = "Villanizacion (Puede electrificar a cualquier persona para volverla un villano en base a sus pecados)",
        });

        List<Personajes> todos = new List<Personajes>() //Aca utilizo polimorfismo osea que meto a todos los personajes en una lista
        {
            Multico, Firestorm, Vortex, Thunderman, Caopton
        };

        bool salir = false; //Sencillo esto es el menu, el booleano solo sirve para el boton de salir
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("===MENU DE PERSONAJES===");

            for (int i = 0; i < todos.Count; i++) //Este for es para enlistar automaticamente los personajes osea 1.2.3.etc
            {
                Console.WriteLine($"{i + 1}. {todos[i].Nombre}");
            }

            Console.WriteLine("Pulse 0 para salir");
            Console.Write("\nElige un personaje: ");

            string entrada = Console.ReadLine(); //Con esto la consola puede leer los datos que ingresemos es como un metodo
            if (entrada == "0") 
            {
                salir = true;
            } 
            else if (int.TryParse(entrada, out int opcion) && opcion >= 1 && opcion <= todos.Count) //TryParse intenta convertir ese texto a entero. Si el usuario escribe "abc" o deja vacío, TryParse devuelve false y no explota el programa
            {
                MostrarPersonaje(todos[opcion - 1]);
                Console.WriteLine("\nPulse cualquier letra para volver: ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La opcion seleccionada no es valida...");
                Console.ReadKey(); //pausa el programa y espera a que el usuario presione cualquier tecla para continuar
            }
        }

        static void MostrarPersonaje(Personajes p)
        {
            Console.Clear();
            Console.WriteLine($"==={p.Nombre}===");
            Console.WriteLine($"==={p.Apodo}===");
            Console.WriteLine($"==={p.Elemento}===");
            Console.WriteLine($"==={p.Estatura}===");
            Console.WriteLine($"==={p.Salud}===");
            Console.WriteLine($"==={p.TonoPiel}===");
            Console.WriteLine($"==={p.Aliados}===");

        //Aca en esta estructura condicional deberia de detectar si es heroe o villano 
        if (p is Heroe h) // el is es para detectar el tipo, osea si es villano, heroe o anti-heroe
        {
            Console.WriteLine($"Tipo: Heroe");
            Console.WriteLine($"Camino: {h.CaminoHeroico}");
        }
        else if (p is Villano v)
        {
            Console.WriteLine($"Tipo: Villano");
            Console.WriteLine($"Trasfondo: {v.Trasfondo}");
        }
        else if (p is AntiHeroe a)
        {
            Console.WriteLine($"Tipo: Anti-Heroe");
            Console.WriteLine($"Inclinacion: {a.Inclinacion}");
            Console.WriteLine($"Apariencia: {a.Apariencia}");
            Console.WriteLine($"Motivacion: {a.Motivacion}");
        }

        Console.WriteLine("\n==Habilidades==");
        foreach (var hab in p.Habilidades) //EL foreach recorre toda la lista que tiene cada personaje y las imprime, Var es para no tener q escribir el tipo
        {
            Console.WriteLine($"Habilidad: {hab.Habilidades}");
            Console.WriteLine($"Arma: {hab.Arma}");
            Console.WriteLine($"Especial: {hab.Especial}");
            Console.WriteLine($"Daño: {hab.Danio}");
            Console.WriteLine($"Movilidad: {hab.Movilidad}");
        }

        }
    }
}