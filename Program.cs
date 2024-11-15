using System;
namespace Archivos_Binarios
{
    class Program
    {
        static void Main()
        {
            string path = "archivoBinario.dat";  
            ArchivoBinario archivo = new ArchivoBinario(path);
            try
            {
                // Crear archivo binario y escribir datos
                archivo.CrearArchivoBinario();

                // Leer el archivo binario
                archivo.LeerArchivoBinario();

                // Modificar el contenido del archivo binario
                archivo.ModificarArchivoBinario();

                // Leer el archivo binario después de la modificación
                archivo.LeerArchivoBinario();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocurrió un error: {e.Message}");
            }
        }
    }
}