using Application;
using AutoMapper;
using BookShopWebApi.DTOs;
using Core;
using Microsoft.AspNetCore.Mvc;

namespace BookShopWebApi.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepo _user;
        private readonly IMapper _mapper;

        public UserController(IUserRepo repo, IMapper mapper)
        {
            _user = repo;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult Registration(UserCreateDTO newUser)
        {
            if(newUser.Login == null && newUser.Password == null)
            {
                return BadRequest();
            }
            else
            {
                var user = _mapper.Map<User>(newUser);
                _user.Registration(user);
                _user.Save();
                return Ok();
            }
        }

        [HttpGet] 
        public IActionResult Authorisation(string autLogin, string autPassword) 
        {
            var user = _user.Authorisation(autLogin, autPassword);
            if(user == null)
            {
                return NotFound("User not found");
            }
            else
            {
                return Ok(user);
            }
        }
    }
}
