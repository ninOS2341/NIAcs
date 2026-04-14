using System;
using System.Management;
using System.Xml.Linq;
/*
    Dispositivos de entrada y salida son todos los perifericos que una pc tiene,
    como el teclado, mouse, pantalla, bocinas, etc.
    El objetivo es que Nia pueda interactuar con los perifericos de la computadora que el 
    usuario le pida o vea necesario usar. <- Aun que no se que tome como \"necesario\".
 */
public class Dispositivos
{
    public string tecladoI = "", tecladoE = "", mouse = "", pantalla = "", bocinas = "", pad="";
    public void DispositivosEntradaSalida()
    {
        var buscador = new ManagementObjectSearcher("SELECT * FROM Win32_Keyboard");
        foreach (var obj in buscador.Get())
        {
            tecladoI = obj["Name"]?.ToString() ?? "No hay teclado";
            Console.WriteLine($"Teclado {tecladoI}");
        }
        buscador = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE PNPClass = 'keyboard'");
        foreach (ManagementObject device in buscador.Get())
        {
          tecladoE = device["Name"]?.ToString() ?? "No hay teclado";
            Console.WriteLine($"Teclado: {tecladoE}");
        }
        buscador = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE PNPClass = 'Mouse'");
        foreach (ManagementObject device in buscador.Get())
        {
            if (device["Description"].ToString().ToLower().Contains("mouse"))
            {
                mouse = device["Name"]?.ToString();
                mouse += " " + device["Description"]?.ToString();
                Console.WriteLine($"Ratón: {mouse}");
            }
            if (device["Description"].ToString().ToLower().Contains("touchpad"))
            {
                pad = device["Name"]?.ToString();
                pad += " " + device["Description"]?.ToString();
                Console.WriteLine($"touchpad: {pad}");
            }

        }
        buscador = new ManagementObjectSearcher("SELECT * FROM Win32_DesktopMonitor");
        foreach (var obj in buscador.Get())
        {
            pantalla = obj["Name"]?.ToString() ?? "No hay pantalla";
            Console.WriteLine($"Pantalla: {pantalla}");
        }
        buscador = new ManagementObjectSearcher("SELECT * FROM Win32_SoundDevice");
        foreach (var obj in buscador.Get())
        {
            bocinas = obj["Name"]?.ToString() ?? "No hay bocinas";
            Console.WriteLine($"Bocinas: {bocinas}");
        }

    }
    
}
