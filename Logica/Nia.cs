using System;
using System.Collections.Generic;
using System.Text;

public class Logica
{
   public string nia = "Hola soy nia";
    public void Nia()
    {
        Console.WriteLine("¡Hola! Soy Nia, tu asistente virtual. ¿En qué puedo ayudarte hoy?");
        var escuchaActiva = new EscuchaActiva();
        while (true)
        {
             escuchaActiva.Escucha();
            if (nia == "salir")
            {
                escuchaActiva.Hablar("¡Hasta luego! Si necesitas algo más, no dudes en volver.");
                Thread.Sleep(2000);
                break;
            }
            else
            {
                escuchaActiva.Hablar(nia);
            }

        }
    }
}
