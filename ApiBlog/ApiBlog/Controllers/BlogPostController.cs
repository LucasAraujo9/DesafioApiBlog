using ApiBlog.DTOs;
using ApiBlog.Interfaces;
using ApiBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiBlog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostService _blogPostService;

        public BlogPostController(IBlogPostService service)
        {
            _blogPostService = service;
        }

        /// <summary>
        /// Busca todos os posts com todos os comentarios
        /// </summary>
        [HttpGet("/api/posts")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _blogPostService.GetAll());
        }

        /// <summary>
        /// Busca posts por Id
        /// </summary>
        [HttpGet("/api/posts/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var post = await _blogPostService.GetById(id);

            if (post == null)
                return NotFound();

            return Ok(post);
        }

        /// <summary>
        /// Adiciona um Post
        /// </summary>
        [HttpPost("/api/posts")]  
        public async Task<IActionResult> Create(BlogPost blogPost)
        {
            var post = await _blogPostService.Post(blogPost);
            if (post)
                return Created();
            else 
                return BadRequest();
        }
    }
}
