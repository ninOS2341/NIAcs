/*
  Program.cs es el inicio de la aplicacion, aqui se llama a la parte esencial del programa
  que es Nia.  
 
*/
using System;
class program
{
    static async Task Main(string[] args)
    {
        /*Estos comentarios son para probar funcionamiento de algun .cs por individual

         var dispositivos = new Dispositivos(); 
        dispositivos.DispositivosEntradaSalida();
       
         */
         var nia = new Logica();
        await nia.Nia();

    }
}
/*
    Nino
    13/4/2026
    ver 0.2.0 "Hola"
    -Notas: se añadio el complejo de la voz
    el complejo del escucha, la ia por OLlama, etc. 
    No hubo mas versiones para 0.1 porque el avance de "quien soy" fue muy rapido
    Las siguientes versiones de 0.2 seran puliendo su habla, escucha, y respuestas.
    para la version 0.3 se tomara el enfoque de los comandos, para que nia pueda realizar siertas acciones faciles
    veriones posteriores seran para crear las bases del control de la computadora en si, para por ejemplo:
    -crear carpetas
    -mover archivos
    -interaccion con el teclado y mouse
    - etc.
 */