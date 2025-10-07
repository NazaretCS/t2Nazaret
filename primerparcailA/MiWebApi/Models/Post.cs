namespace Parcial1{

public class Post
{
    private int id;
    private string titulo;
    private string contenido;
    private DateTime fechaCreacion;
    
    private Reaccion reaccion;

    public int Id { get => id; set => id = value; }
    public string Titulo { get => titulo; set => titulo = value; }
    public string Contenido { get => contenido; set => contenido = value; }
    public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
    public Reaccion Reaccion { get => reaccion; set => reaccion = value; }


    //Constructor
    /* public Tarea(int id, string titulo, string descripcion, string estado)
    {
        IdTarea = id;
        Titulo = titulo;
        Descripcion = descripcion;
        Estado = estado;
    }


    public Tarea()
    {
        //Inicializa las propiedades requeridas
        IdTarea = 0;
        Titulo = string.Empty;
        Descripcion = string.Empty;
        Estado = string.Empty;
    } */

}
}