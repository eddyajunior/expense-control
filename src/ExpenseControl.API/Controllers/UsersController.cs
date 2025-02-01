using ExpenseControl.Domain.User;
using ExpenseControl.Domain.User.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseControl.API.Controllers
{
    /// <summary>
    /// Users controller
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ICreateUserUseCase _createUserUseCase;

        public UsersController(ICreateUserUseCase createUserUseCase)
        {
            _createUserUseCase = createUserUseCase;
        }

        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/users")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Create([FromBody] UserEntity user)
        {
            _createUserUseCase.Create(user);

            return Ok();
        }

        /// <summary>
        /// Get a user by id
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/users/{idUser}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetById([FromRoute]int idUser)
        {
            return Ok();
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/users")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Get()
        {
            return Ok();
        }

        /// <summary>
        /// Delete a user by id
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/users/{idUser}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Delete([FromRoute] int idUser)
        {
            return Ok();
        }

        /// <summary>
        /// Update a user by id
        /// </summary>
        /// <param name="idUser"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("/users/{idUser}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Update([FromRoute] int idUser, [FromBody] UserEntity user)
        {
            return Ok();
        }
    }

    
}
