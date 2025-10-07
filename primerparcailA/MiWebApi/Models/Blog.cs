
namespace Parcial1{
    

public class Blog
{
    private string nombre;
    private string descripcion;
    private List<Post> listadoPost;

    
    public string Nombre { get => nombre; set => nombre = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    private List<Post> ListadoPost { get => listadoPost; set => listadoPost = value; }

    public Blog()
    {
        Nombre = string.Empty;
        Descripcion = string.Empty;
    }

    public Blog(string nombre, string descripcion, List<Post> listaPost){
        Nombre = nombre;
        Descripcion = descripcion;
        List<Post> ListadoPost = listadoPost;
    }
}

}