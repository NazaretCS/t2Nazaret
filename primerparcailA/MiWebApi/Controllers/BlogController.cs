using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Parcial1
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly ManejoDePost manejoDePost = new ManejoDePost();

        // GET: api/blog/posts
        [HttpGet("posts")]
        public async Task<ActionResult<List<Post>>> ObtenerTodos()
        {
            var posts = await manejoDePost.ObtenerTodosLosPost();
            return Ok(posts);
        }

        // GET: api/blog/posts/{id}
        [HttpGet("posts/{id}")]
        public async Task<ActionResult<Post>> ObtenerPorId(int id)
        {
            var post = await manejoDePost.ObtenerPostPorId(id);
            if (post == null)
                return NotFound("Post no encontrado");

            return Ok(post);
        }

        // POST: api/blog/posts
        [HttpPost("posts")]
        public async Task<IActionResult> Crear([FromBody] Post post)
        {
            await manejoDePost.GuardarPost(post);
            return Ok("Post creado correctamente");
        }

        // PUT: api/blog/posts/{id}
        [HttpPut("posts/{id}")]
        public async Task<IActionResult> Actualizar(int id, [FromBody] Post post)
        {
            post.Id = id;
            await manejoDePost.ActualizarPost(post);
            return Ok("Post actualizado");
        }

        // POST: api/blog/posts/megusta/{id}
        [HttpPost("posts/megusta/{id}")]
        public async Task<IActionResult> MeGusta(int id)
        {
            await manejoDePost.IncrementarMG(id);
            return Ok("Me gusta incrementado 👍");
        }

        // DELETE: api/blog/posts/{id}
        [HttpDelete("posts/{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            await manejoDePost.EliminarPost(id);
            return Ok("Post eliminado correctamente");
        }
    }
}
