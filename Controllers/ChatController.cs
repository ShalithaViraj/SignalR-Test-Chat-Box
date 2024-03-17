using chatBox.Dtos;
using chatBox.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace chatBox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly ChatService _chatService;
        public ChatController(ChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost("register-user")]
        public IActionResult RegisterUser(UserDto model)
        {
            if (_chatService.AddUserToList(model.Name))
            {
                return NoContent();
            }
            return BadRequest("This name is already exists");
        }
    }
}
