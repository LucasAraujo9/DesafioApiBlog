using ApiBlog.Interfaces;
using ApiBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiBlog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService service)
        {
            _commentService = service;
        }

        /// <summary>
        /// Adiciona um Comment a um Post
        /// </summary>
        [HttpPost("/api/posts/{id}/comments")]
        public async Task<IActionResult> Create(int id, Comment comment)
        {
            var commentary = await _commentService.Post(id, comment);
            if (commentary)
                return Created();
            else
                return BadRequest();
        }
    }
}
