public class Personajes
{
    public string Nombre {get; set;}
    public string Apodo {get; set;}
    public Double Estatura {get; set;}
    public string TonoPiel {get; set;}
    public int Salud {get; set;}
    public string Aliados {get; set;}
    public string Elemento {get; set;}
    public List<Habilidad> Habilidades { get; set; } = new List<Habilidad>();
}

public class Habilidad
{
    public string Habilidades {get; set;}
    public string Arma {get; set;}
    public string Especial {get; set;}
    public string Danio {get; set;}
    public string Movilidad {get; set;}
} 

public class Heroe : Personajes
{
    public string CaminoHeroico {get; set;}
}

public class Villano : Personajes
{
    public string Trasfondo {get; set;}
}

public class AntiHeroe : Personajes
{
    public string Inclinacion {get; set;}
    public string Apariencia {get; set;}
    public string Motivacion {get; set;}
}
