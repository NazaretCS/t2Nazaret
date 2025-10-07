using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1{
    public class ManejoDePost{
        private AccesoADatos accesoADatos;

        public ManejoDePost(){
            accesoADatos = new AccesoADatos();
        }

        public async Task<List<Post>> ObtenerTodosLosPost()
        {
            return await accesoADatos.ObtenerPost();
        }
        
        public async Task<Post> ObtenerPostPorId(int id)
        {
            List<Post> posts = await accesoADatos.ObtenerPost();
            return posts.FirstOrDefault(t => t.Id == id);
        }

        public async Task GuardarPost(Post post)
        {
            List<Post> posts = await accesoADatos.ObtenerPost();
            posts.Add(post);
            await accesoADatos.GuardarPost(posts);
        }

        public async Task ActualizarPost(Post postActualizado)
        {
            List<Post> posts = await accesoADatos.ObtenerPost();
            int index = posts.FindIndex(t => t.Id == postActualizado.Id);
            if (index >= 0)
            {
                posts[index] = postActualizado;
                await accesoADatos.GuardarPost(posts);
            }
        }

        public async Task EliminarPost(int id)
        {
            List<Post> posts = await accesoADatos.ObtenerPost();
            posts.RemoveAll(t => t.Id == id);
            await accesoADatos.GuardarPost(posts);
        }

        public async Task IncrementarMG(int id)
        {
            List<Post> posts = await accesoADatos.ObtenerPost();
            Post post = posts.FirstOrDefault(t => t.Id == id);
            post.Reaccion.CantidadDeMeGusta += 1;
            int index = posts.FindIndex(t => t.Id == post.Id);
            if (index >= 0)
            {
                posts[index] = post;
                await accesoADatos.GuardarPost(posts);
            }
        }

    }
}