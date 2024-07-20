using System;
using System.Collections.Generic;

public class Traductor
{
    private static readonly Dictionary<string, string> clave = new Dictionary<string, string>()
    {
        {"A", "Haa"},
        {"B", "Eetha"},
        {"C", "Hass"},
        {"D", "SsSha"},
        {"E", "Ssss"},
        {"F", "Hassay"},
        {"G", "EehH"},
        {"H", "Seetha"},
        {"I", "Ayya"},
        {"J", "Sheay"},
        {"K", "Ayath"},
        {"L", "Hatehh"},
        {"M", "SssHh"},
        {"N", "Hathh"},
        {"Ñ", "Seytha"},
        {"O", "Ayeeh"},
        {"P", "Aah"},
        {"Q", "AtheyA"},
        {"R", "Hassey"},
        {"S", "SsHei"},
        {"T", "Sseya"},
        {"U", "Essehie"},
        {"V", "Sshatay"},
        {"W", "Hatheey"},
        {"X", "Seeh"},
        {"Y", "Haah"},
        {"Z", "SsSeth"},
        {" ", " "}, 
        {"á", "Ayay"},
        {"é", "Eeh"},
        {"í", "Iyay"},
        {"ó", "Ooy"},
        {"ú", "Uuy"},
        {"ü", "Uuy"},
        {"ñ", "Seytha"},
    };

    public static string Traducir(string texto)
    {
        string textoTraducido = "";
        foreach (char letra in texto)
        {
            string letraCodificada = clave.ContainsKey(letra.ToString().ToUpper()) ? clave[letra.ToString().ToUpper()] : letra.ToString();
            textoTraducido += letraCodificada;
        }
        return textoTraducido;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Meta el texto");
        string textoOriginal = Console.ReadLine();
        string textoTraducido = Traducir(textoOriginal);
        Console.WriteLine("Texto traducido: {0}", textoTraducido);
    }
}
