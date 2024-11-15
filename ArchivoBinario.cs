using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Archivos_Binarios
{
    public class ArchivoBinario
    {
        public string Path { get; set; }
        public ArchivoBinario(string path)
        {
            Path = path;
        }
        public void CrearArchivoBinario()
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(Path, FileMode.Create)))
                {
                    writer.Write(12345);           // Escribimos un entero
                    writer.Write(3.14159);         // Escribimos un doble
                    writer.Write("Texto binario"); // Escribimos una cadena
                }
                Console.WriteLine("Archivo binario creado y datos escritos correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al crear el archivo binario: {e.Message}");
            }
        }
        public void LeerArchivoBinario()
        {
            try
            {
                if (File.Exists(Path))
                {
                    using (BinaryReader reader = new BinaryReader(File.Open(Path, FileMode.Open)))
                    {
                        int entero = reader.ReadInt32();   // Leemos el entero
                        double decimalNum = reader.ReadDouble();  // Leemos el doble
                        string texto = reader.ReadString();  // Leemos la cadena

                        Console.WriteLine($"Entero: {entero}");
                        Console.WriteLine($"Doble: {decimalNum}");
                        Console.WriteLine($"Texto: {texto}");
                    }
                }
                else
                {
                    Console.WriteLine("El archivo binario no existe.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al leer el archivo binario: {e.Message}");
            }
        }

        public void ModificarArchivoBinario()
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(Path, FileMode.Append)))
                {
                    writer.Write(67890);          // Escribimos un nuevo entero
                    writer.Write("Nuevo texto");  // Escribimos una nueva cadena
                }
                Console.WriteLine("Datos añadidos correctamente al archivo binario.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al modificar el archivo binario: {e.Message}");
            }
        }
    }
}