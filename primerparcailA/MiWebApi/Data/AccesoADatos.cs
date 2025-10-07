
namespace Parcial1{


using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

public class AccesoADatos
{
    private readonly string rutaArchivo = "post.json";

    public async Task<List<Post>> ObtenerPost()
    {
        List<Post> posts = new List<Post>();

        try
        {
            if (File.Exists(rutaArchivo))
            {
                string json = await File.ReadAllTextAsync(rutaArchivo);
                posts = JsonSerializer.Deserialize<List<Post>>(json);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al obtener Los posts: {ex.Message}");
        }

        return posts;
    }

    public async Task GuardarPost(List<Post> posts)
    {
        try
        {
            string json = JsonSerializer.Serialize(posts, new JsonSerializerOptions
            {
                WriteIndented = true 
            });
            await File.WriteAllTextAsync(rutaArchivo, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al guardar los post: {ex.Message}");
        }
    }
}

}